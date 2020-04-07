using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoV83.Models;

namespace UmbracoV83.Contollers
{
    public class ContactFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult SubmitFrom (ContentFrom model) {
            if (ModelState.IsValid) {
                MailMessage mailMessage = new MailMessage(model.Email, "464924371@qq.com");
                mailMessage.Subject = model.Subject;
                mailMessage.Body = model.Message;

                SmtpClient smtpClient = new SmtpClient("127.0.0.1", 25);
                smtpClient.Send(mailMessage);
                TempData["ContactResult"] = "邮件已经发送..";
                return RedirectToCurrentUmbracoPage();
            }

            return CurrentUmbracoPage();
        }
        
    }
}