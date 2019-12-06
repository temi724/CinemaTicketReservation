using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.Models;
using CaptchaMvc.HtmlHelpers;

using Easytickets.com.Models;

namespace Easytickets.com.Controllers
{
    public class RegistrationController : Controller
    {
        EasyTicketsData _db = new EasyTicketsData();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RegisterNow(Registration registration)
        {
            if (this.IsCaptchaValid("Validate"))
            {
                try
                {
                    Registration reg = new Registration();
                    reg.Name = registration.Name;
                    reg.Email = registration.Email;
                    reg.PhoneNumber = registration.PhoneNumber;
                    reg.PassWord = registration.PassWord;
                    reg.DateOfRegistration = DateTime.Now;
                    reg.RegistrtationID = Services.AddtionalServices.GenerateRegID();
                    _db.Registrations.Add(reg);
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.Log("Something is wrong");
                    return RedirectToAction("Index");
                }
                ViewBag.Login = "Provide your login detials";
                return RedirectToAction("Index", "Account");

            }
            else
            {
                ViewBag.note = "You have to fill in all informations correctly";
                return View();
            }
          
        }
    }


}