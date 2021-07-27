using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Common
{
    public class MailHelper123
    {
        public void SendMail(string toMailAddress, string subject,string content)
        {
            var fromEmailAddress = ConfigurationManager.AppSettings["FromEmailAddress"].ToString();
            var fromEmailDisplayName = ConfigurationManager.AppSettings["FromEmailDisplayName"].ToString();
            var fromEmailPassword = ConfigurationManager.AppSettings["FromEmailPassword"].ToString();
            var smtpHort = ConfigurationManager.AppSettings["SMTPHost"].ToString();
            var smtpport = ConfigurationManager.AppSettings["SMTPPort"].ToString();


            bool enabledSSL = bool.Parse(ConfigurationManager.AppSettings["EnableSSL"].ToString());

            string body = content;
            MailMessage message = new MailMessage(new MailAddress(fromEmailAddress, fromEmailDisplayName), new MailAddress(toMailAddress));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = body;

            var client = new SmtpClient();
            client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
            client.Host = smtpHort;
            client.EnableSsl = enabledSSL;
            client.Port = !string.IsNullOrEmpty(smtpport) ? Convert.ToInt32(smtpport) : 0;
            client.Send(message);
        }
    }
}
