using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Mvc4ContactForm.Models;

namespace Mvc4ContactForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Receive submit contact from client.
        [HttpPost]
        public ActionResult Contact(ContactModels c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    msg.To.Add("pitsanu.t@carpass.co.th");
                    msg.Subject = "Contact Us";
                    msg.From = new MailAddress("contact.web@carpass.co.th");
                    msg.Body = "First name: " + c.FirstName;
                    msg.Body += "Last name: " + c.LastName;

                    msg.IsBodyHtml = true;
                    smtp.Host = "bentley.CARPASSAD.CO.TH";
                    //smtp.Port = 25;
                    smtp.Send(msg);
                    msg.Dispose();
                    //return View("Success");

                    throw new Exception("Just want to throw something :)");
                }
                catch (Exception)
                {
                    return View("Error");
                }
            }
            return View();
        }
    }
}
