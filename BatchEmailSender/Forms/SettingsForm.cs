using BatchEmailSender.Properties;
using MailKit.Security;
using System.Diagnostics;

namespace BatchEmailSender.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            SocketOptionsComboBox.DataSource = Enum.GetValues(typeof(SecureSocketOptions));
        }

    }
}
