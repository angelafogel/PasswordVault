using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;

namespace PasswordVaultNS
{
    public class EmailNotification
    {
        public virtual bool SendEmail()
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient("mail.sacredheart.edu");

            message.From = new MailAddress("noreply@sacredheart.edu");
            message.To.Add("user@sacredheart.edu");
            message.Subject = "Password vault account password hint";
            message.Body = "The password hint for the Password account: ";

            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("username", "password");
            client.EnableSsl = true;
            client.Send(message);

            return true;
        }
    }
}
