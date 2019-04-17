using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace Login.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login.Models.gmail mail)
        {
           string result = null;
            try
            {
                MailMessage mailMessage = new MailMessage("shilpa.eis2@gmail.com ", mail.To);
                mailMessage.Subject = mail.Subject;
                mailMessage.Body = mail.Body;
                mailMessage.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential("shilpa.eis2@gmail.com", "Assignment");
                smtp.UseDefaultCredentials = true;

                smtp.Credentials = nc;
                smtp.Send(mailMessage);
                ViewBag.Message = "Mail has been sent successfuly";

                if (ModelState.IsValid)
                {

                    //saving
                    if (string.IsNullOrEmpty(result))
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch
            {
                ViewBag.Message = "Message Error!!! Please enter a valid Email Id";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index","Customer" );
        }
    }
}