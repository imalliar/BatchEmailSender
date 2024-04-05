namespace BatchEmailSender.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainToolStrip = new ToolStrip();
            SettingsToolStripButton = new ToolStripButton();
            ExcelToolStripButton = new ToolStripButton();
            SendMailsToolStripButton = new ToolStripButton();
            MainTabControl = new TabControl();
            EmailTabPage = new TabPage();
            ToNameComboBox = new ComboBox();
            ToNameLabel = new Label();
            BodyHtmlEditor = new TextBox();
            FromNameTextBox = new TextBox();
            FromNameLabel = new Label();
            ToComboBox = new ComboBox();
            BrowseAttachmentButton = new Button();
            AttachmentTextBox = new TextBox();
            AttachLabel = new Label();
            ToLabel = new Label();
            FromTextBox = new TextBox();
            FromLabel = new Label();
            TextLabel = new Label();
            SubjectTextBox = new TextBox();
            SubjectLlabel = new Label();
            ExcelTabPage = new TabPage();
            ExcelDataGridView = new DataGridView();
            ErrosTabPage = new TabPage();
            ErrorsDataGridView = new DataGridView();
            SuccessTabPage = new TabPage();
            SuccessReportDataGridView = new DataGridView();
            ExcelOpenFileDialog = new OpenFileDialog();
            AttachmentOpenFileDialog = new OpenFileDialog();
            SenderBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            MainToolStrip.SuspendLayout();
            MainTabControl.SuspendLayout();
            EmailTabPage.SuspendLayout();
            ExcelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExcelDataGridView).BeginInit();
            ErrosTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorsDataGridView).BeginInit();
            SuccessTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SuccessReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MainToolStrip
            // 
            MainToolStrip.Items.AddRange(new ToolStripItem[] { SettingsToolStripButton, ExcelToolStripButton, SendMailsToolStripButton });
            MainToolStrip.Location = new Point(0, 0);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new Size(1076, 25);
            MainToolStrip.TabIndex = 0;
            MainToolStrip.Text = "toolStrip1";
            // 
            // SettingsToolStripButton
            // 
            SettingsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SettingsToolStripButton.Image = (Image)resources.GetObject("SettingsToolStripButton.Image");
            SettingsToolStripButton.ImageTransparentColor = Color.Magenta;
            SettingsToolStripButton.Name = "SettingsToolStripButton";
            SettingsToolStripButton.Size = new Size(23, 22);
            SettingsToolStripButton.Text = "Settings";
            SettingsToolStripButton.Click += SettingsToolStripButton_Click;
            // 
            // ExcelToolStripButton
            // 
            ExcelToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ExcelToolStripButton.Image = (Image)resources.GetObject("ExcelToolStripButton.Image");
            ExcelToolStripButton.ImageTransparentColor = Color.Magenta;
            ExcelToolStripButton.Name = "ExcelToolStripButton";
            ExcelToolStripButton.Size = new Size(23, 22);
            ExcelToolStripButton.Text = "Excel";
            ExcelToolStripButton.ToolTipText = "Import Excel File";
            ExcelToolStripButton.Click += ExcelToolStripButton_Click;
            // 
            // SendMailsToolStripButton
            // 
            SendMailsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SendMailsToolStripButton.Image = (Image)resources.GetObject("SendMailsToolStripButton.Image");
            SendMailsToolStripButton.ImageTransparentColor = Color.Magenta;
            SendMailsToolStripButton.Name = "SendMailsToolStripButton";
            SendMailsToolStripButton.Size = new Size(23, 22);
            SendMailsToolStripButton.Text = "Send Mails";
            SendMailsToolStripButton.Click += SendMailsToolStripButton_Click;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EmailTabPage);
            MainTabControl.Controls.Add(ExcelTabPage);
            MainTabControl.Controls.Add(ErrosTabPage);
            MainTabControl.Controls.Add(SuccessTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.HotTrack = true;
            MainTabControl.Location = new Point(0, 25);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1076, 482);
            MainTabControl.TabIndex = 0;
            // 
            // EmailTabPage
            // 
            EmailTabPage.Controls.Add(ToNameComboBox);
            EmailTabPage.Controls.Add(ToNameLabel);
            EmailTabPage.Controls.Add(BodyHtmlEditor);
            EmailTabPage.Controls.Add(FromNameTextBox);
            EmailTabPage.Controls.Add(FromNameLabel);
            EmailTabPage.Controls.Add(ToComboBox);
            EmailTabPage.Controls.Add(BrowseAttachmentButton);
            EmailTabPage.Controls.Add(AttachmentTextBox);
            EmailTabPage.Controls.Add(AttachLabel);
            EmailTabPage.Controls.Add(ToLabel);
            EmailTabPage.Controls.Add(FromTextBox);
            EmailTabPage.Controls.Add(FromLabel);
            EmailTabPage.Controls.Add(TextLabel);
            EmailTabPage.Controls.Add(SubjectTextBox);
            EmailTabPage.Controls.Add(SubjectLlabel);
            EmailTabPage.Location = new Point(4, 24);
            EmailTabPage.Name = "EmailTabPage";
            EmailTabPage.Padding = new Padding(3);
            EmailTabPage.Size = new Size(1068, 454);
            EmailTabPage.TabIndex = 0;
            EmailTabPage.Text = "Email";
            EmailTabPage.UseVisualStyleBackColor = true;
            // 
            // ToNameComboBox
            // 
            ToNameComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ToNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToNameComboBox.FormattingEnabled = true;
            ToNameComboBox.Location = new Point(501, 77);
            ToNameComboBox.Name = "ToNameComboBox";
            ToNameComboBox.Size = new Size(557, 23);
            ToNameComboBox.TabIndex = 14;
            // 
            // ToNameLabel
            // 
            ToNameLabel.AutoSize = true;
            ToNameLabel.Location = new Point(439, 80);
            ToNameLabel.Margin = new Padding(4, 0, 4, 0);
            ToNameLabel.Name = "ToNameLabel";
            ToNameLabel.Size = new Size(54, 15);
            ToNameLabel.TabIndex = 13;
            ToNameLabel.Text = "To Name";
            // 
            // BodyHtmlEditor
            // 
            BodyHtmlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BodyHtmlEditor.Location = new Point(8, 162);
            BodyHtmlEditor.Multiline = true;
            BodyHtmlEditor.Name = "BodyHtmlEditor";
            BodyHtmlEditor.Size = new Size(1054, 286);
            BodyHtmlEditor.TabIndex = 12;
            // 
            // FromNameTextBox
            // 
            FromNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FromNameTextBox.Location = new Point(501, 48);
            FromNameTextBox.Margin = new Padding(4, 3, 4, 3);
            FromNameTextBox.Name = "FromNameTextBox";
            FromNameTextBox.Size = new Size(557, 23);
            FromNameTextBox.TabIndex = 5;
            // 
            // FromNameLabel
            // 
            FromNameLabel.AutoSize = true;
            FromNameLabel.Location = new Point(423, 51);
            FromNameLabel.Margin = new Padding(4, 0, 4, 0);
            FromNameLabel.Name = "FromNameLabel";
            FromNameLabel.Size = new Size(70, 15);
            FromNameLabel.TabIndex = 4;
            FromNameLabel.Text = "From Name";
            // 
            // ToComboBox
            // 
            ToComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Location = new Point(58, 77);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(355, 23);
            ToComboBox.TabIndex = 7;
            // 
            // BrowseAttachmentButton
            // 
            BrowseAttachmentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseAttachmentButton.Location = new Point(1018, 107);
            BrowseAttachmentButton.Margin = new Padding(4, 3, 4, 3);
            BrowseAttachmentButton.Name = "BrowseAttachmentButton";
            BrowseAttachmentButton.Size = new Size(40, 27);
            BrowseAttachmentButton.TabIndex = 10;
            BrowseAttachmentButton.Text = "...";
            BrowseAttachmentButton.UseVisualStyleBackColor = true;
            BrowseAttachmentButton.Click += BrowseAttachmentButton_Click;
            // 
            // AttachmentTextBox
            // 
            AttachmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AttachmentTextBox.Location = new Point(58, 107);
            AttachmentTextBox.Margin = new Padding(4, 3, 4, 3);
            AttachmentTextBox.Name = "AttachmentTextBox";
            AttachmentTextBox.Size = new Size(956, 23);
            AttachmentTextBox.TabIndex = 9;
            // 
            // AttachLabel
            // 
            AttachLabel.AutoSize = true;
            AttachLabel.Location = new Point(11, 110);
            AttachLabel.Margin = new Padding(4, 0, 4, 0);
            AttachLabel.Name = "AttachLabel";
            AttachLabel.Size = new Size(42, 15);
            AttachLabel.TabIndex = 8;
            AttachLabel.Text = "Attach";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(34, 81);
            ToLabel.Margin = new Padding(4, 0, 4, 0);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(19, 15);
            ToLabel.TabIndex = 6;
            ToLabel.Text = "To";
            // 
            // FromTextBox
            // 
            FromTextBox.Location = new Point(58, 48);
            FromTextBox.Margin = new Padding(4, 3, 4, 3);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.Size = new Size(355, 23);
            FromTextBox.TabIndex = 3;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(18, 51);
            FromLabel.Margin = new Padding(4, 0, 4, 0);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(35, 15);
            FromLabel.TabIndex = 2;
            FromLabel.Text = "From";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(9, 144);
            TextLabel.Margin = new Padding(4, 0, 4, 0);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(34, 15);
            TextLabel.TabIndex = 11;
            TextLabel.Text = "Body";
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubjectTextBox.Location = new Point(58, 18);
            SubjectTextBox.Margin = new Padding(4, 3, 4, 3);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(1000, 23);
            SubjectTextBox.TabIndex = 1;
            // 
            // SubjectLlabel
            // 
            SubjectLlabel.AutoSize = true;
            SubjectLlabel.Location = new Point(7, 21);
            SubjectLlabel.Margin = new Padding(4, 0, 4, 0);
            SubjectLlabel.Name = "SubjectLlabel";
            SubjectLlabel.Size = new Size(46, 15);
            SubjectLlabel.TabIndex = 0;
            SubjectLlabel.Text = "Subject";
            // 
            // ExcelTabPage
            // 
            ExcelTabPage.Controls.Add(ExcelDataGridView);
            ExcelTabPage.Location = new Point(4, 24);
            ExcelTabPage.Name = "ExcelTabPage";
            ExcelTabPage.Padding = new Padding(3);
            ExcelTabPage.Size = new Size(1068, 454);
            ExcelTabPage.TabIndex = 1;
            ExcelTabPage.Text = "Excel";
            ExcelTabPage.UseVisualStyleBackColor = true;
            // 
            // ExcelDataGridView
            // 
            ExcelDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExcelDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ExcelDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExcelDataGridView.Dock = DockStyle.Fill;
            ExcelDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ExcelDataGridView.Location = new Point(3, 3);
            ExcelDataGridView.Name = "ExcelDataGridView";
            ExcelDataGridView.Size = new Size(1062, 448);
            ExcelDataGridView.TabIndex = 0;
            // 
            // ErrosTabPage
            // 
            ErrosTabPage.Controls.Add(ErrorsDataGridView);
            ErrosTabPage.Location = new Point(4, 24);
            ErrosTabPage.Name = "ErrosTabPage";
            ErrosTabPage.Padding = new Padding(3);
            ErrosTabPage.Size = new Size(1068, 454);
            ErrosTabPage.TabIndex = 2;
            ErrosTabPage.Text = "Errors";
            ErrosTabPage.UseVisualStyleBackColor = true;
            // 
            // ErrorsDataGridView
            // 
            ErrorsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ErrorsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ErrorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ErrorsDataGridView.Dock = DockStyle.Fill;
            ErrorsDataGridView.Location = new Point(3, 3);
            ErrorsDataGridView.Name = "ErrorsDataGridView";
            ErrorsDataGridView.Size = new Size(1062, 448);
            ErrorsDataGridView.TabIndex = 0;
            // 
            // SuccessTabPage
            // 
            SuccessTabPage.Controls.Add(SuccessReportDataGridView);
            SuccessTabPage.Location = new Point(4, 24);
            SuccessTabPage.Name = "SuccessTabPage";
            SuccessTabPage.Padding = new Padding(3);
            SuccessTabPage.Size = new Size(1068, 454);
            SuccessTabPage.TabIndex = 3;
            SuccessTabPage.Text = "Success Report";
            SuccessTabPage.UseVisualStyleBackColor = true;
            // 
            // SuccessReportDataGridView
            // 
            SuccessReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SuccessReportDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SuccessReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuccessReportDataGridView.Dock = DockStyle.Fill;
            SuccessReportDataGridView.Location = new Point(3, 3);
            SuccessReportDataGridView.Name = "SuccessReportDataGridView";
            SuccessReportDataGridView.Size = new Size(1062, 448);
            SuccessReportDataGridView.TabIndex = 1;
            // 
            // ExcelOpenFileDialog
            // 
            ExcelOpenFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            // 
            // AttachmentOpenFileDialog
            // 
            AttachmentOpenFileDialog.FileName = "openFileDialog1";
            // 
            // SenderBackgroundWorker
            // 
            SenderBackgroundWorker.WorkerReportsProgress = true;
            SenderBackgroundWorker.WorkerSupportsCancellation = true;
            SenderBackgroundWorker.DoWork += SenderBackgroundWorker_DoWork;
            SenderBackgroundWorker.ProgressChanged += SenderBackgroundWorker_ProgressChanged;
            SenderBackgroundWorker.RunWorkerCompleted += SenderBackgroundWorker_RunWorkerCompleted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 507);
            Controls.Add(MainTabControl);
            Controls.Add(MainToolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Batch Email Sender";
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            MainTabControl.ResumeLayout(false);
            EmailTabPage.ResumeLayout(false);
            EmailTabPage.PerformLayout();
            ExcelTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ExcelDataGridView).EndInit();
            ErrosTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ErrorsDataGridView).EndInit();
            SuccessTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SuccessReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip MainToolStrip;
        private ToolStripButton SettingsToolStripButton;
        private TabControl MainTabControl;
        private TabPage EmailTabPage;
        private TabPage ExcelTabPage;
        private Button BrowseAttachmentButton;
        private TextBox AttachmentTextBox;
        private Label AttachLabel;
        private Label ToLabel;
        private TextBox FromTextBox;
        private Label FromLabel;
        private Label TextLabel;
        private TextBox SubjectTextBox;
        private Label SubjectLlabel;
        private ToolStripButton ExcelToolStripButton;
        private OpenFileDialog ExcelOpenFileDialog;
        private DataGridView ExcelDataGridView;
        private ComboBox ToComboBox;
        private OpenFileDialog AttachmentOpenFileDialog;
        private ToolStripButton SendMailsToolStripButton;
        private TabPage ErrosTabPage;
        private DataGridView ErrorsDataGridView;
        private TextBox FromNameTextBox;
        private Label FromNameLabel;
        private System.ComponentModel.BackgroundWorker SenderBackgroundWorker;
        private TextBox BodyHtmlEditor;
        private ComboBox ToNameComboBox;
        private Label ToNameLabel;
        private TabPage SuccessTabPage;
        private DataGridView SuccessReportDataGridView;
    }
}