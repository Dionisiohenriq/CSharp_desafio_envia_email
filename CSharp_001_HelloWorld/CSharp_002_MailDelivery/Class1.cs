using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web;


namespace CSharp_002_MailDelivery
{
    class EnviaEmail
    {
        static SmtpClient Client;
        static MailMessage Msg;
        static void Main(string [] args) 
        {

            enviaEmail();

        }
        static void enviaEmail()
        {
            Msg = new MailMessage();
            Msg.Body = "teste";
            Msg.From = new MailAddress("henriquedionisio.dionisioferre@gmail.com");
            Msg.Subject = "teste";
            List<string> p = new List<string>();
            Msg.To.Add("henriquedionisio.dionisioferre@gmail.com");
            Msg.To.Add("menuube@hotmail.com");
            
            foreach(string pessoa in p)
            {
                Msg.To.Add(pessoa);
            }


            Client = new SmtpClient();
            Client.Credentials = new NetworkCredential("henriquedionisio.dionisioferre@gmail.com", "************");
            Client.Port = 587;
            Client.Host = "smtp.gmail.com";
            Client.EnableSsl = true;
            Client.Send(Msg);
            
        }
    }
}
