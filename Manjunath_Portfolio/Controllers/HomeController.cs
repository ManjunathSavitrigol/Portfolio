using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace Manjunath_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMail(mailobject emailset)
        {
            try
            {
                MailMessage mail = new MailMessage();
                //mail.To.Add("rohitgaikwad853@gmail.com");
                mail.To.Add(emailset.Email);
                mail.From = new MailAddress("savitrigolmanjunath@gmail.com");
                mail.Subject = emailset.Subject;
                mail.Body = emailset.Message;
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = Convert.ToInt32(587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("savitrigolmanjunath@gmail.com", "qnru yszf mvqh jsye"); // Enter senders User name and password  
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch
            {

            }
            return View("Index");
        }


    }

    public class mailobject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}