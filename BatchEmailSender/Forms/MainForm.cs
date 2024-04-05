using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.Net.Mail;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Windows.Forms;
using BatchEmailSender.Extensions;
using BatchEmailSender.Models;
using BatchEmailSender.Properties;
using BatchEmailSender.Utils;
using FluentEmail.Core;
using FluentEmail.Liquid;
using FluentEmail.MailKitSmtp;
using FluentEmail.Smtp;
using Fluid;
using Fluid.Values;
using MailKit.Security;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using OfficeOpenXml;

namespace BatchEmailSender.Forms;

public partial class MainForm : Form
{
    private readonly Dictionary<string, int> _columns = new();
    private readonly List<ColumnsModel> _columnsModel = new();
    private DataTable _excelData = new();
    private List<ErrorModel> _errors = new();
    private List<SuccessReportModel> _successReports = new();
    private WaitForm? _waitForm = null;

    public MainForm()
    {
        InitializeComponent();
    }

    private void SettingsToolStripButton_Click(object sender, EventArgs e)
    {
        SettingsForm settings = new SettingsForm();
        settings.ServerTextBox.Text = Settings.Default.Server;
        settings.PortNumericUpDown.Value = Settings.Default.Port;
        settings.UseSslCheckBox.Checked = Settings.Default.UseSsl;
        settings.UserTextBox.Text = Settings.Default.User;
        settings.PasswordTextBox.Text = Settings.Default.Password;
        settings.DelayNumericUpDown.Value = Settings.Default.Delay;
        settings.RequiresAuthenticationCheckBox.Checked = Settings.Default.RequiresAuthentication;
        settings.SocketOptionsComboBox.SelectedItem = (SecureSocketOptions)Enum.ToObject(typeof(SecureSocketOptions), Settings.Default.SocketOptions);

        if (settings.ShowDialog() == DialogResult.OK)
        {
            Settings.Default.Server = settings.ServerTextBox.Text;
            Settings.Default.Port = (int)settings.PortNumericUpDown.Value;
            Settings.Default.UseSsl = settings.UseSslCheckBox.Checked;
            Settings.Default.User = settings.UserTextBox.Text;
            Settings.Default.Password = settings.PasswordTextBox.Text;
            Settings.Default.Delay = (int)settings.DelayNumericUpDown.Value;
            Settings.Default.RequiresAuthentication = settings.RequiresAuthenticationCheckBox.Checked;
            Settings.Default.SocketOptions = (int)settings.SocketOptionsComboBox.SelectedValue;
            Settings.Default.Save();
        }
    }

    private void ExcelToolStripButton_Click(object sender, EventArgs e)
    {
        if (ExcelOpenFileDialog.ShowDialog() == DialogResult.OK)
        {
            using var package = new ExcelPackage(ExcelOpenFileDialog.FileName);
            ExcelWorksheet workSheet = package.Workbook.Worksheets[0];


            var start = workSheet.Dimension.Start;
            var end = workSheet.Dimension.End;

            _columns.Clear();
            _columnsModel.Clear();

            _excelData = workSheet.Cells[start.Row, start.Column, end.Row, end.Column].ToDataTable();


            foreach (DataColumn column in _excelData.Columns)
            {
                _columns[column.ColumnName] = column.Ordinal;
                _columnsModel.Add(new ColumnsModel
                {
                    Name = column.ColumnName,
                    Index = column.Ordinal
                });
            }

            ToComboBox.DataSource = new BindingList<ColumnsModel>(_columnsModel);
            ToComboBox.ValueMember = nameof(ColumnsModel.Index);
            ToComboBox.DisplayMember = nameof(ColumnsModel.Name);

            ToNameComboBox.DataSource = new BindingList<ColumnsModel>(_columnsModel);
            ToNameComboBox.ValueMember = nameof(ColumnsModel.Index);
            ToNameComboBox.DisplayMember = nameof(ColumnsModel.Name);

            ExcelDataGridView.DataSource = _excelData;
        }
    }

    private void BrowseAttachmentButton_Click(object sender, EventArgs e)
    {
        if (AttachmentOpenFileDialog.ShowDialog() == DialogResult.OK)
            AttachmentTextBox.Text = AttachmentOpenFileDialog.FileName;
    }

    private void SendMailsToolStripButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(SubjectTextBox.Text))
        {
            MessageBox.Show("Subject cannot be null", "Send Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (string.IsNullOrEmpty(Settings.Default.Server))
        {
            MessageBox.Show("You must define an SMTP Server at settings", "Send Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (string.IsNullOrEmpty(FromTextBox.Text))
        {
            MessageBox.Show("From field cannot be null", "Send Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (!EmailUtils.IsValid(FromTextBox.Text))
        {
            MessageBox.Show("From is not a valid email address", "Send Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (string.IsNullOrEmpty(ToComboBox.Text))
        {
            MessageBox.Show("You should load the Excel file first and select the 'To' column", "Send Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        _waitForm = new WaitForm(SenderBackgroundWorker, _excelData.Rows.Count);

        SenderBackgroundWorker.RunWorkerAsync(new SenderWorkerOptions
        {
            From = FromTextBox.Text,
            FromName = FromNameTextBox.Text,
            Subject = SubjectTextBox.Text,
            To = ToComboBox.Text,
            ToName = ToNameComboBox.Text,
            Template = BodyHtmlEditor.Text
        });
        _waitForm.ShowDialog();
        ErrorsDataGridView.DataSource = _errors;
        SuccessReportDataGridView.DataSource = _successReports;
    }

    private void SenderBackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
    {
        _waitForm?.Close();
    }

    private void SenderBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
    {
        SenderWorkerOptions options = e.Argument as SenderWorkerOptions ?? new SenderWorkerOptions();

        Email.DefaultSender = new MailKitSender(new SmtpClientOptions
        {
            Password = Settings.Default.Password,
            Port = Settings.Default.Port,
            Server = Settings.Default.Server,
            User = Settings.Default.User,
            UseSsl = Settings.Default.UseSsl,
            RequiresAuthentication = Settings.Default.RequiresAuthentication,
            SocketOptions = (SecureSocketOptions)Enum.ToObject(typeof(SecureSocketOptions), Settings.Default.SocketOptions)
        });
        Email.From(options.From, options.FromName);

        var parser = new FluidParser();
        
        IEnumerable<dynamic> rows = _excelData.ToDynamic();
        int progress = 0;
        _errors = new List<ErrorModel>();
        string? currentTo=null, currentToName = null;
        
        foreach (var currentRow in rows)
        {
            var row = currentRow as IDictionary<string, object?>;
            if (row == null) continue;
            try
            {
                currentTo = row[options.To].ToString();
                currentToName = row[options.ToName].ToString();
                if (string.IsNullOrEmpty(currentTo)) continue;


                if (parser.TryParse(options.Template, out var template, out var error))
                {

                    //var context = new TemplateContext();

                    var context = new TemplateContext(currentRow);
                    var compiled = template.Render(context);

                    var email = new Email()
                        .SetFrom(options.From, options.FromName)
                        .To(currentTo, currentToName)
                        .Subject(options.Subject)
                        .Body(compiled);

                    var response = email.Send();

                    if (response.Successful)
                    {
                        _successReports.Add(new SuccessReportModel
                        {
                            Email = currentTo,
                            EmailName = currentToName,
                            MessageId = response.MessageId
                        });
                    }
                    else
                    {
                        foreach (string message in response.ErrorMessages)
                        {
                            _errors.Add(new ErrorModel
                            {
                                Email = currentTo,
                                EmailName = currentToName,
                                Error = message
                            });
                        }
                    }
                }
                else
                {
                    _errors.Add(new ErrorModel
                    {
                        Email = currentTo,
                        EmailName = currentToName,
                        Error = error
                    });
                }

                Task.Delay(Settings.Default.Delay * 1000);
                SenderBackgroundWorker.ReportProgress(++progress);
                if (SenderBackgroundWorker.CancellationPending) break;
            }
            catch (Exception ex)
            {
                _errors.Add(new ErrorModel
                {
                    Email = currentTo,
                    EmailName = currentToName,
                    Error = ex.Message
                });
            }
        }

    }

    private void SenderBackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
    {
        if (_waitForm != null) 
            _waitForm.ProgressBarWait.Value = e.ProgressPercentage;
    }
}