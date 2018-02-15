using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Ado.Net._8.HW.BTW.Model;


namespace Ado.Net._8.HW.BTW
{
    class Program
    {
       private static MCS db = new MCS();
        static void Main(string[] args)
        {
        
        }

        static void Task1()
        {
            if (db.ChangeTracker.HasChanges()) {

                try
                {
                    MailMessage mail = new MailMessage("timur.samig@gmail.com", "timur.samigulin@yandex.kz");

                    mail.From = new MailAddress("emailfrom");
                    mail.Subject = "Changes";
                    string Body = "Database was changed";
                    mail.Body = Body;

                    mail.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                    smtp.Credentials = new System.Net.NetworkCredential("timur.samig@gmail.com", "password");

                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    Console.WriteLine("Письмо отправлено");
                    mail = null;
                    smtp = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
            }


        }
    }
}
