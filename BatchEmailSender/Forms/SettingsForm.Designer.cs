namespace BatchEmailSender.Forms
{
    partial class SettingsForm
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
            CancelButton = new Button();
            OkButton = new Button();
            ServerLabel = new Label();
            ServerTextBox = new TextBox();
            label1 = new Label();
            PortNumericUpDown = new NumericUpDown();
            UserTextBox = new TextBox();
            UserLabel = new Label();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            UseSslCheckBox = new CheckBox();
            DelayNumericUpDown = new NumericUpDown();
            DelayLabel = new Label();
            RequiresAuthenticationCheckBox = new CheckBox();
            SocketOptionsLabel = new Label();
            SocketOptionsComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PortNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DelayNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(612, 349);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(531, 349);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // ServerLabel
            // 
            ServerLabel.AutoSize = true;
            ServerLabel.Location = new Point(12, 9);
            ServerLabel.Name = "ServerLabel";
            ServerLabel.Size = new Size(72, 15);
            ServerLabel.TabIndex = 2;
            ServerLabel.Text = "SMTP Server";
            // 
            // ServerTextBox
            // 
            ServerTextBox.Location = new Point(133, 6);
            ServerTextBox.Name = "ServerTextBox";
            ServerTextBox.PlaceholderText = "e.g. smtp.contosco.com";
            ServerTextBox.Size = new Size(557, 23);
            ServerTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "SMTP Port";
            // 
            // PortNumericUpDown
            // 
            PortNumericUpDown.Location = new Point(133, 35);
            PortNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            PortNumericUpDown.Name = "PortNumericUpDown";
            PortNumericUpDown.Size = new Size(120, 23);
            PortNumericUpDown.TabIndex = 5;
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(133, 64);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.PlaceholderText = "e.g. User";
            UserTextBox.Size = new Size(557, 23);
            UserTextBox.TabIndex = 7;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(12, 67);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(30, 15);
            UserLabel.TabIndex = 6;
            UserLabel.Text = "User";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(133, 93);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(557, 23);
            PasswordTextBox.TabIndex = 9;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(12, 96);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Password";
            // 
            // UseSslCheckBox
            // 
            UseSslCheckBox.AutoSize = true;
            UseSslCheckBox.Location = new Point(139, 180);
            UseSslCheckBox.Name = "UseSslCheckBox";
            UseSslCheckBox.Size = new Size(66, 19);
            UseSslCheckBox.TabIndex = 10;
            UseSslCheckBox.Text = "Use SSL";
            UseSslCheckBox.UseVisualStyleBackColor = true;
            // 
            // DelayNumericUpDown
            // 
            DelayNumericUpDown.Location = new Point(133, 122);
            DelayNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            DelayNumericUpDown.Name = "DelayNumericUpDown";
            DelayNumericUpDown.Size = new Size(124, 23);
            DelayNumericUpDown.TabIndex = 12;
            // 
            // DelayLabel
            // 
            DelayLabel.AutoSize = true;
            DelayLabel.Location = new Point(12, 124);
            DelayLabel.Name = "DelayLabel";
            DelayLabel.Size = new Size(115, 15);
            DelayLabel.TabIndex = 11;
            DelayLabel.Text = "Delay Between Mails";
            // 
            // RequiresAuthenticationCheckBox
            // 
            RequiresAuthenticationCheckBox.AutoSize = true;
            RequiresAuthenticationCheckBox.Location = new Point(211, 180);
            RequiresAuthenticationCheckBox.Name = "RequiresAuthenticationCheckBox";
            RequiresAuthenticationCheckBox.Size = new Size(153, 19);
            RequiresAuthenticationCheckBox.TabIndex = 13;
            RequiresAuthenticationCheckBox.Text = "Requires Authentication";
            RequiresAuthenticationCheckBox.UseVisualStyleBackColor = true;
            // 
            // SocketOptionsLabel
            // 
            SocketOptionsLabel.AutoSize = true;
            SocketOptionsLabel.Location = new Point(12, 154);
            SocketOptionsLabel.Name = "SocketOptionsLabel";
            SocketOptionsLabel.Size = new Size(87, 15);
            SocketOptionsLabel.TabIndex = 15;
            SocketOptionsLabel.Text = "Socket Options";
            // 
            // SocketOptionsComboBox
            // 
            SocketOptionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SocketOptionsComboBox.FormattingEnabled = true;
            SocketOptionsComboBox.Location = new Point(133, 151);
            SocketOptionsComboBox.Name = "SocketOptionsComboBox";
            SocketOptionsComboBox.Size = new Size(557, 23);
            SocketOptionsComboBox.TabIndex = 16;
            // 
            // SettingsForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 384);
            Controls.Add(SocketOptionsComboBox);
            Controls.Add(SocketOptionsLabel);
            Controls.Add(RequiresAuthenticationCheckBox);
            Controls.Add(DelayNumericUpDown);
            Controls.Add(DelayLabel);
            Controls.Add(UseSslCheckBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserTextBox);
            Controls.Add(UserLabel);
            Controls.Add(PortNumericUpDown);
            Controls.Add(label1);
            Controls.Add(ServerTextBox);
            Controls.Add(ServerLabel);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)PortNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DelayNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button OkButton;
        private Label ServerLabel;
        private Label label1;
        private Label UserLabel;
        private Label PasswordLabel;
        public TextBox ServerTextBox;
        public NumericUpDown PortNumericUpDown;
        public TextBox UserTextBox;
        public TextBox PasswordTextBox;
        public CheckBox UseSslCheckBox;
        public NumericUpDown DelayNumericUpDown;
        private Label DelayLabel;
        public CheckBox RequiresAuthenticationCheckBox;
        private Label SocketOptionsLabel;
        public ComboBox SocketOptionsComboBox;
    }
}