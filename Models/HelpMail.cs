using NWebsec.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DCXEMAY.Models
{
    public class HelpMail
    {
        public void SendMail(string toMailAddress, string subject, string content)
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
            message.IsBodyHtml = false;
            message.Body = body;

            var client = new SmtpClient();
            client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
            client.Host = smtpHort;
            client.EnableSsl = enabledSSL;
            client.Port = !string.IsNullOrEmpty(smtpport) ? Convert.ToInt32(smtpport) : 100000;
            client.Send(message);
        }
    }
}