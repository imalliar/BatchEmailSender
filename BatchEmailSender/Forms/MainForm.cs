using System.ComponentModel;
using System.Data;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using BatchEmailSender.Extensions;
using BatchEmailSender.Models;
using BatchEmailSender.Properties;
using BatchEmailSender.Utils;
using FluentEmail.Core;
using FluentEmail.Liquid;
using FluentEmail.MailKitSmtp;
using FluentEmail.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using OfficeOpenXml;

namespace BatchEmailSender.Forms;

public partial class MainForm : Form
{
    private readonly Dictionary<string, int> _columns = new();
    private readonly List<ColumnsModel> _columnsModel = new();
    private DataTable _excelData = new();
    private List<ErrorModel> _errors = new();
    private WaitForm? _waitForm = null;
    private string? _to;
    private string? _subject;
    private string? _template;
    private int _delay;
    private string _from;
    private string _fromName;


    public MainForm()
    {
        InitializeComponent();
        SendMailsToolStripButton.Click += async (sender, e) => await SendMailsToolStripButton_Click(sender, e);
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

        if (settings.ShowDialog() == DialogResult.OK)
        {
            Settings.Default.Server = settings.ServerTextBox.Text;
            Settings.Default.Port = (int)settings.PortNumericUpDown.Value;
            Settings.Default.UseSsl = settings.UseSslCheckBox.Checked;
            Settings.Default.User = settings.UserTextBox.Text;
            Settings.Default.Password = settings.PasswordTextBox.Text;
            Settings.Default.Delay = (int)settings.DelayNumericUpDown.Value;
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

            ToComboBox.DataSource = _columnsModel;
            ToComboBox.ValueMember = nameof(ColumnsModel.Index);
            ToComboBox.DisplayMember = nameof(ColumnsModel.Name);

            ExcelDataGridView.DataSource = _excelData;
        }
    }

    private void BrowseAttachmentButton_Click(object sender, EventArgs e)
    {
        if (AttachmentOpenFileDialog.ShowDialog() == DialogResult.OK)
            AttachmentTextBox.Text = AttachmentOpenFileDialog.FileName;
    }

    private async Task SendMailsToolStripButton_Click(object sender, EventArgs e)
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

        _to = ToComboBox.Text;
        _subject = SubjectTextBox.Text;
        _template = BodyHtmlEditor.Text;
        _delay = Settings.Default.Delay;
        _from = FromTextBox.Text;
        _fromName = FromNameTextBox.Text;

        SenderBackgroundWorker.RunWorkerAsync();
        _waitForm.ShowDialog();
        ErrorsDataGridView.DataSource = _errors;
    }

    private void SenderBackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
    {
        _waitForm?.Close();
    }

    private void SenderBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
    {
        Email.DefaultSender = new MailKitSender(new SmtpClientOptions
        {
            Password = Settings.Default.Password,
            Port = Settings.Default.Port,
            Server = Settings.Default.Server,
            User = Settings.Default.User,
            UseSsl = Settings.Default.UseSsl,
            //RequiresAuthentication = true,
            SocketOptions = SecureSocketOptions.StartTlsWhenAvailable
        });
        Email.From(_from, _fromName);

        var options = new LiquidRendererOptions();
        Email.DefaultRenderer = new LiquidRenderer(Options.Create(options));
        
        IEnumerable<dynamic> rows = _excelData.ToDynamic();
        int progress = 0;
        _errors = new List<ErrorModel>();
        string? currentTo=null;
        
        foreach (var currentRow in rows)
        {
            var row = currentRow as IDictionary<string, object?>;
            if (row == null) continue;
            try
            {
                currentTo = row[_to].ToString();
                if (string.IsNullOrEmpty(currentTo)) continue;

                var email = new Email()
                    .SetFrom(_from, _fromName)
                    .To(currentTo)
                    .Subject(_subject)
                    .Body("Test body");
                    //.UsingTemplate(_template, row);

                var response = email.Send();

                
                    
                Task.Delay(_delay * 1000);
                SenderBackgroundWorker.ReportProgress(++progress);
                if (SenderBackgroundWorker.CancellationPending) break;
            }
            catch (Exception ex)
            {
                _errors.Add(new ErrorModel
                {
                    Email = currentTo,
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