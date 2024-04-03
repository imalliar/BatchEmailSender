namespace BatchEmailSender
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainToolStrip = new ToolStrip();
            SettingsToolStripButton = new ToolStripButton();
            ExcelToolStripButton = new ToolStripButton();
            SendMailsToolStripButton = new ToolStripButton();
            MainTabControl = new TabControl();
            EmailTabPage = new TabPage();
            ToComboBox = new ComboBox();
            BodyHtmlEditor = new Zoople.HTMLEditControl();
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
            ExcelOpenFileDialog = new OpenFileDialog();
            AttachmentOpenFileDialog = new OpenFileDialog();
            ErrosTabPage = new TabPage();
            ErrorsDataGridView = new DataGridView();
            MainToolStrip.SuspendLayout();
            MainTabControl.SuspendLayout();
            EmailTabPage.SuspendLayout();
            ExcelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExcelDataGridView).BeginInit();
            ErrosTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorsDataGridView).BeginInit();
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
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.HotTrack = true;
            MainTabControl.Location = new Point(0, 25);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1076, 482);
            MainTabControl.TabIndex = 1;
            // 
            // EmailTabPage
            // 
            EmailTabPage.Controls.Add(ToComboBox);
            EmailTabPage.Controls.Add(BodyHtmlEditor);
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
            // ToComboBox
            // 
            ToComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ToComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Location = new Point(58, 77);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(1000, 23);
            ToComboBox.TabIndex = 25;
            // 
            // BodyHtmlEditor
            // 
            BodyHtmlEditor.AcceptsReturn = true;
            BodyHtmlEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BodyHtmlEditor.AutoSize = true;
            BodyHtmlEditor.BaseURL = null;
            BodyHtmlEditor.CleanMSWordHTMLOnPaste = true;
            BodyHtmlEditor.CSSText = null;
            BodyHtmlEditor.DocumentHTML = null;
            BodyHtmlEditor.EnableInlineSpelling = false;
            BodyHtmlEditor.FontSizesList = null;
            BodyHtmlEditor.FontsList = null;
            BodyHtmlEditor.HiddenButtons = null;
            BodyHtmlEditor.ImageStorageLocation = null;
            BodyHtmlEditor.InCodeView = false;
            BodyHtmlEditor.IndentAmount = 2;
            BodyHtmlEditor.IndentsUseBlockuote = false;
            BodyHtmlEditor.LanguageFile = null;
            BodyHtmlEditor.LicenceActivationKey = null;
            BodyHtmlEditor.LicenceKey = null;
            BodyHtmlEditor.LicenceKeyInlineSpelling = null;
            BodyHtmlEditor.Location = new Point(11, 162);
            BodyHtmlEditor.Name = "BodyHtmlEditor";
            BodyHtmlEditor.Size = new Size(1049, 284);
            BodyHtmlEditor.TabIndex = 24;
            BodyHtmlEditor.ToolstripImageScalingSize = new Size(16, 16);
            BodyHtmlEditor.UseParagraphAsDefault = true;
            // 
            // BrowseAttachmentButton
            // 
            BrowseAttachmentButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseAttachmentButton.Location = new Point(1018, 107);
            BrowseAttachmentButton.Margin = new Padding(4, 3, 4, 3);
            BrowseAttachmentButton.Name = "BrowseAttachmentButton";
            BrowseAttachmentButton.Size = new Size(40, 27);
            BrowseAttachmentButton.TabIndex = 22;
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
            AttachmentTextBox.TabIndex = 21;
            // 
            // AttachLabel
            // 
            AttachLabel.AutoSize = true;
            AttachLabel.Location = new Point(11, 110);
            AttachLabel.Margin = new Padding(4, 0, 4, 0);
            AttachLabel.Name = "AttachLabel";
            AttachLabel.Size = new Size(42, 15);
            AttachLabel.TabIndex = 20;
            AttachLabel.Text = "Attach";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(34, 81);
            ToLabel.Margin = new Padding(4, 0, 4, 0);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(19, 15);
            ToLabel.TabIndex = 18;
            ToLabel.Text = "To";
            // 
            // FromTextBox
            // 
            FromTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FromTextBox.Location = new Point(58, 48);
            FromTextBox.Margin = new Padding(4, 3, 4, 3);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.Size = new Size(1000, 23);
            FromTextBox.TabIndex = 17;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(18, 51);
            FromLabel.Margin = new Padding(4, 0, 4, 0);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(35, 15);
            FromLabel.TabIndex = 16;
            FromLabel.Text = "From";
            // 
            // TextLabel
            // 
            TextLabel.AutoSize = true;
            TextLabel.Location = new Point(9, 144);
            TextLabel.Margin = new Padding(4, 0, 4, 0);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(34, 15);
            TextLabel.TabIndex = 14;
            TextLabel.Text = "Body";
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubjectTextBox.Location = new Point(58, 18);
            SubjectTextBox.Margin = new Padding(4, 3, 4, 3);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(1000, 23);
            SubjectTextBox.TabIndex = 13;
            // 
            // SubjectLlabel
            // 
            SubjectLlabel.AutoSize = true;
            SubjectLlabel.Location = new Point(7, 21);
            SubjectLlabel.Margin = new Padding(4, 0, 4, 0);
            SubjectLlabel.Name = "SubjectLlabel";
            SubjectLlabel.Size = new Size(46, 15);
            SubjectLlabel.TabIndex = 12;
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
            // ExcelOpenFileDialog
            // 
            ExcelOpenFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            // 
            // AttachmentOpenFileDialog
            // 
            AttachmentOpenFileDialog.FileName = "openFileDialog1";
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
            ErrorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ErrorsDataGridView.Dock = DockStyle.Fill;
            ErrorsDataGridView.Location = new Point(3, 3);
            ErrorsDataGridView.Name = "ErrorsDataGridView";
            ErrorsDataGridView.Size = new Size(1062, 448);
            ErrorsDataGridView.TabIndex = 0;
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
        private Zoople.HTMLEditControl BodyHtmlEditor;
        private ToolStripButton ExcelToolStripButton;
        private OpenFileDialog ExcelOpenFileDialog;
        private DataGridView ExcelDataGridView;
        private ComboBox ToComboBox;
        private OpenFileDialog AttachmentOpenFileDialog;
        private ToolStripButton SendMailsToolStripButton;
        private TabPage ErrosTabPage;
        private DataGridView ErrorsDataGridView;
    }
}