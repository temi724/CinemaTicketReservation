using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;
using Easytickets.com.Models;

namespace Easytickets.com.Controllers
{
    public class AccountController : Controller
    {
        private EasyTicketsData _db = new EasyTicketsData();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Registration registration)
        {
            var LogMeIn = _db.Registrations.Where(x => x.Email
             == registration.Email && x.PassWord == registration.PassWord).FirstOrDefault();
            if (LogMeIn != null && LogMeIn.AdminPass == false)
            {
                var GetName = _db.Registrations.Where(x => x.Email == LogMeIn.Email).FirstOrDefault();
                Session["User"] = GetName.Name;
                Session["ID"] = GetName.ID;
                return RedirectToAction("User", "Ticket");
            }
            else if (LogMeIn != null && LogMeIn.AdminPass == true) {
                var GetName = _db.Registrations.Where(x => x.Email == LogMeIn.Email).FirstOrDefault();
                Session["User"] = GetName.Name;
                Session["ID"] = GetName.ID;
                return RedirectToAction("SeeUsersAndTicketDetails","Admin");
            }

            else
            {
                ViewBag.error = "Please make sure your user name and password is correct";
                return RedirectToAction("Index", "Account");
            }
            

        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}