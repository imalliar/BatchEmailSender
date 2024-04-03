using System.Net.Mail;

namespace BatchEmailSender.Utils;

public static class EmailUtils
{
    public static bool IsValid(string email)
    {
        var valid = true;

        try
        {
            var emailAddress = new MailAddress(email);
        }
        catch
        {
            valid = false;
        }

        return valid;
    }
}