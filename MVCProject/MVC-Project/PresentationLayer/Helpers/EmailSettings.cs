using DataAccessLayer.Models;
using System.Net;
using System.Net.Mail;

namespace PresentationLayer.Helpers
{
    public static class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            var Client = new SmtpClient("smtp.gmail.com", 587);
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential("yousefsamehmahmoud@gmail.com", "PasswordGeneratedByGoogle");
            Client.Send("yousefsamehmahmoud@gmail.com", email.To, email.Subject, email.Body);
        }
    }
}
