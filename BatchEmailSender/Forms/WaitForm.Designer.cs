namespace BatchEmailSender.Forms {
	partial class WaitForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
            ProgressBarWait = new ProgressBar();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // ProgressBarWait
            // 
            ProgressBarWait.Location = new Point(14, 14);
            ProgressBarWait.Margin = new Padding(4, 3, 4, 3);
            ProgressBarWait.Name = "ProgressBarWait";
            ProgressBarWait.Size = new Size(694, 27);
            ProgressBarWait.Step = 1;
            ProgressBarWait.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(334, 57);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // WaitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 92);
            Controls.Add(CancelButton);
            Controls.Add(ProgressBarWait);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WaitForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Παρακαλώ περιμένετε";
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.ProgressBar ProgressBarWait;
        private Button CancelButton;
    }
}