using System;
using System.Net;
using System.Net.Mail;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sender = "sender@server.ru";
            string recepient = "recepient@server.ru";
            System.Net.Mail.MailMessage msg = new MailMessage(sender, recepient);
            msg.Subject = "Тема сообщения";
            msg.Body = "Текст сообщения";
            msg.IsBodyHtml = false;
            System.Net.Mail.SmtpClient client = new SmtpClient("smtp.mail.ru", 587);
            client.EnableSsl = true;
            //string UserName = Console.ReadLine();
            string UserName = "leftacccount";
            //string Password = Console.ReadLine();
            string Password = "Microchip88";
            client.Credentials = new NetworkCredential(UserName, Password);
            client.Send(msg);            
        }
    }
}
