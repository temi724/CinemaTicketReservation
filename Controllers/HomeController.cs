using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Easytickets.com.Models;
using Easytickets.com.ViewModel;
namespace Easytickets.com.Controllers
{

    public class HomeController : Controller
    {
        //Making the database availabe for use in the home controller...
        private EasyTicketsData _db = new EasyTicketsData();
        /// <summary>
        /// The index method returns the list of available movies,songs and sports
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var availableMovies = _db.Movies.ToList();
            var availableSongs = _db.Musics.ToList();
            var availableSports = _db.Sports.ToList();
            ViewBag.availableMoviesNow = availableMovies;
            ViewBag.availableSongs = availableSongs;
            ViewBag.availableSports = availableSports;
            return View();
        }

        //public ActionResult CheckMyTicketDetails(DataViewModel dm) {
        //    string userID =dm.UserID;
        //    if (userID != null)
        //    {
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}