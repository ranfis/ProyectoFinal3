using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace TravelAgency
{
    public static class EnviadorDeCorreos
    {
        public static void envialEmail(String email, String asunto, String msg)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("travelagemcy.dom@gmail.com");
            mail.To.Add(email);
            mail.Subject = asunto;
            mail.Body = msg;
            mail.IsBodyHtml = true;
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("travelagemcy.dom", "19172967");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }

}