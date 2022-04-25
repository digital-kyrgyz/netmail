using System;
using System.Net.Mail;

namespace ConsoleNetMail
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("", "");
            client.Port = 587;
            client.Host = "smtp.yandex.ru";
            client.EnableSsl = true;
            message.To.Add("melis99mrx@gmail.com");
            message.From = new MailAddress("");
            message.IsBodyHtml = true;
            message.Subject = "Оповещание";
            message.Body = "Это сообщение от правительство налоговая";
            client.Send(message);
            Console.WriteLine("Successfully");
            client.Dispose();
        }
    }
}