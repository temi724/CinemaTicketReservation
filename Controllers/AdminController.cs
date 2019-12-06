using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Easytickets.com.Models;
using Easytickets.com.ViewModel;

namespace Easytickets.com.Controllers
{
    public class AdminController : Controller
    {
        EasyTicketsData _db = new EasyTicketsData();
        // GET: Admin
        public ActionResult SeeUsersAndTicketDetails() {
            int getUserID = Convert.ToInt32(Session["ID"]);
            if (getUserID > 0) {
                var movieTicket = (from a in _db.Registrations
                                   join b in _db.BookedTickets
                                   on a.RegistrtationID equals b.UserID
                                   join c in _db.Movies on b.ActionID equals c.ID
                                   
                                   
                                   select new
                                   {
                                       yourName = a.Name,
                                       ticketNumber = b.TicketID,
                                       movieName = c.MovieName,
                                       showingIn = c.ShowingIn,
                                       showingTime = c.Time
                                   }
                                                   ).ToList();
                List<DataViewModel> dv = new List<DataViewModel>();
                foreach (var movie in movieTicket)
                {
                    dv.Add(new DataViewModel
                    {
                        Name=movie.yourName,
                        MovieName = movie.movieName,
                        TicketID = movie.ticketNumber,
                        ShowingIn = movie.showingIn,
                        Time = movie.showingTime

                    });
                }
                ViewBag.BookedMovies = dv;

                var musics = (from a in _db.Registrations
                              join b in _db.MusicTicket
                              on a.RegistrtationID equals b.UserID
                              join c in _db.Musics on b.ActionID equals c.ID
                              where a.ID >0
                              select new
                              {
                                  mName = a.Name,
                                  mticketNumber = b.TicketID,
                                  martist = c.Artist,
                                  mshowingIn = c.ShowingIn,
                                  mshowingTime = c.Time


                              }).ToList();

                List<DataViewModel> mv = new List<DataViewModel>();
                foreach (var music in musics)
                {
                    mv.Add(new DataViewModel
                    {
                        Name=music.mName,
                        Artist = music.martist,
                        TicketID = music.mticketNumber,
                        ShowingIn = music.mshowingIn,
                        Time = music.mshowingTime
                    });


                };

                ViewBag.music = mv;


                //Sports..........................................................
                var sports = (from a in _db.Registrations
                              join b in _db.BookSportTickets
                              on a.RegistrtationID equals b.UserID
                              join c in _db.Sports on b.ActionID equals c.ID
                              where a.ID >0
                              select new
                              {
                                 yourname = a.Name,
                                  ticketNumber = b.TicketID,
                                  Name = c.SportName,
                                  showingIn = c.ShowingIn,
                                  showingTime = c.Time


                              }).ToList();

                List<DataViewModel> sv = new List<DataViewModel>();
                foreach (var sport in sports)
                {
                    sv.Add(new DataViewModel
                    {
                        Name=sport.yourname,
                        SportName = sport.Name,
                        TicketID = sport.ticketNumber,
                        ShowingIn = sport.showingIn,
                        Time = sport.showingTime
                    });


                };

                ViewBag.sport = sv;


            }
            else
            {
                return RedirectToAction("Index", "Account");
            }

            return View();

        }
    }
}