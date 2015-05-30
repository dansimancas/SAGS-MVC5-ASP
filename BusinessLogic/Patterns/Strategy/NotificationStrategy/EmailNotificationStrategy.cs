using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace BusinessLogic
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        private string from;
        private string fromPassword;
        private string to;
        private string subject;
        private string body;

        public void sendNotification(IMember M, string title, string message)
        {
            this.from = "euforsita@gmail.com";
            this.fromPassword = "3155496882";
            this.to = M.EmailAddresses;
            this.subject = title;
            this.body = message;

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(this.from, this.fromPassword);
                MailMessage msg = new MailMessage();
                msg.To.Add(this.to);
                msg.From = new MailAddress(this.from);
                msg.Subject = this.subject;
                msg.Body = this.body;

                client.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable so send email. " + e.Message);
            }
        }
    }
}
