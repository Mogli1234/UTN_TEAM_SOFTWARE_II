using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using  System.Net;

namespace AccesoDatos.Entidades
{
    public class Email
    {
        private bool status;
        private string userName = "jaimeesquivelgomez@gmail.com";
        private string password = "Jaime123";

        public Boolean email_send(string fromMail, string toEmail,string subject,string bodyMessage)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(fromMail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = bodyMessage;
                
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(userName,password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                status = true;
            }
            catch (Exception )
            {
                status = false;
            }
            return status;
        }
    }
}
