using System.ComponentModel;

namespace BatchEmailSender.Forms {
    public partial class WaitForm : Form
    {
        private readonly BackgroundWorker _worker;

        public WaitForm(BackgroundWorker worker, int mailCount)
        {
            InitializeComponent();
            _worker = worker;
            ProgressBarWait.Maximum = mailCount;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _worker.CancelAsync();
            Close();
        }
    }
}
