using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace lesson_3_1
{
    static class SendMail
    {
        static public void Send(string fromMail, string fromPass, string toMail, int port, string smtpServer, string textMail, string headerMail)
        {

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(fromMail, fromPass);
                client.Host = smtpServer;
                client.Port = port;
                client.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromMail);
                mail.To.Add(toMail);
                mail.Subject = headerMail;
                mail.Body = textMail;
                client.Send(mail);
           
        }
    }
}
