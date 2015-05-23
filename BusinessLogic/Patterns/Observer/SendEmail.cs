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
    public class SendEmail
    {
        private string from;
        private string fromPassword;
        private string to;
        private List<string> tos;
        private string subject;
        private string body;

        public SendEmail(string t, string s, string b)
        {
            this.from = Settings.Default["fromEmail"].ToString();
            this.fromPassword = Settings.Default["fromPassword"].ToString();
            this.to = t;
            this.subject = s;
            this.body = b;

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

        public SendEmail(List<string> t, string s, string b)
        {
            this.from = Settings.Default["fromEmail"].ToString();
            this.fromPassword = Settings.Default["fromPassword"].ToString();
            this.tos = t;
            this.subject = s;
            this.body = b;

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(this.from, this.fromPassword);
                MailMessage msg = new MailMessage();
                msg.To.Add(separateEmails());
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

        private string separateEmails()
        {
            string message = "";
            if (tos != null)
            {
                foreach (string email in tos)
                {
                    message += email + ",";
                }
                return message.Substring(0, message.Length - 1);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
