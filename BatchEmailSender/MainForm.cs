using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchEmailSender.Models;
using BatchEmailSender.Properties;
using BatchEmailSender.Utils;
using OfficeOpenXml;

namespace BatchEmailSender;

public partial class MainForm : Form
{
    private readonly Dictionary<string, int> _columns = new();
    private readonly List<ColumnsModel> _columnsModel = new();
    private DataTable _excelData = new();
    private readonly List<ErrorModel> _errors = new();

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

        if (settings.ShowDialog() == DialogResult.OK)
        {
            Settings.Default.Server = settings.ServerTextBox.Text;
            Settings.Default.Port = (int)settings.PortNumericUpDown.Value;
            Settings.Default.UseSsl = settings.UseSslCheckBox.Checked;
            Settings.Default.User = settings.UserTextBox.Text;
            Settings.Default.Password = settings.PasswordTextBox.Text;
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

    }
}