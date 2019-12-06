using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Easytickets.com.Models;
using Easytickets.com.ViewModel;

namespace Easytickets.com.Controllers
{
    public class TicketController : Controller
    {
        private EasyTicketsData _db = new EasyTicketsData();
        // GET: Ticket
        public ActionResult User()
        {
            string getUser = Session["User"].ToString();
            if (getUser != null)
            {
                var availableMovies = _db.Movies.ToList();
                var availableSongs = _db.Musics.ToList();
                var availableSports = _db.Sports.ToList();
                ViewBag.availableMoviesNow = availableMovies;
                ViewBag.availableSongs = availableSongs;
                ViewBag.availableSports = availableSports;
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
            return View();
        }

        public ActionResult BookMovieTicket(int ID)
        {
            string getUser = Session["User"].ToString();
            int getUserID = Convert.ToInt32(Session["ID"]);
            if (ID != 0 && getUserID > 0)
            {
                try
                {
                    var thisUserId = _db.Registrations.Where(x => x.ID == getUserID).FirstOrDefault();
                    string userRegID = thisUserId.RegistrtationID;
                    BookedTicket bookedTicket = new BookedTicket();
                    bookedTicket.TicketID = Services.AddtionalServices.GenerateBookingNumber();
                    bookedTicket.UserID = userRegID;
                    bookedTicket.ActionID = ID;
                    _db.BookedTickets.Add(bookedTicket);
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.log("Something went wrong");
                }
            }
            else
            {
                ViewBag.issh = "something went wrong";
                return RedirectToAction("User", "Tickets");

            }
            return RedirectToAction("Reservation");

        }

        public ActionResult BookMusicTicket(int ID)
        {
            string getUser = Session["User"].ToString();
            int getUserID = Convert.ToInt32(Session["ID"]);
            if (ID != 0 && getUserID > 0)
            {
                try
                {
                    var thisUserId = _db.Registrations.Where(x => x.ID == getUserID).FirstOrDefault();
                    string userRegID = thisUserId.RegistrtationID;
                    MusicTicket musicTicket = new MusicTicket();
                    musicTicket.TicketID = Services.AddtionalServices.GenerateBookingNumber();
                    musicTicket.UserID = userRegID;
                    musicTicket.ActionID = ID;
                    _db.MusicTicket.Add(musicTicket);
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.log("Something went wrong");
                }
            }
            else
            {
                ViewBag.issh = "something went wrong";
                return RedirectToAction("User", "Tickets");

            }
            return RedirectToAction("Reservation");

        }

        public ActionResult BookSportTicket(int ID)
        {
            string getUser = Session["User"].ToString();
            int getUserID = Convert.ToInt32(Session["ID"]);
            if (ID != 0 && getUserID > 0)
            {
                try
                {
                    var thisUserId = _db.Registrations.Where(x => x.ID == getUserID).FirstOrDefault();
                    string userRegID = thisUserId.RegistrtationID;
                    BookSportTicket bookS = new BookSportTicket();
                    bookS.TicketID = Services.AddtionalServices.GenerateBookingNumber();
                    bookS.UserID = userRegID;
                    bookS.ActionID = ID;
                    _db.BookSportTickets.Add(bookS);
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.log("Something went wrong");
                }
            }
            else
            {
                ViewBag.issh = "something went wrong";
                return RedirectToAction("User", "Tickets");

            }
            return RedirectToAction("Reservation");

        }




        public ActionResult Reservation()
        {
            int getUserID = Convert.ToInt32(Session["ID"]);
            if (getUserID > 0)
            {
                var movieBookings = (from a in _db.Registrations
                                     join b in _db.BookedTickets
                                     on a.RegistrtationID equals b.UserID
                                     join c in _db.Movies on b.ActionID equals c.ID
                                     where a.ID == getUserID
                                     select new
                                     {
                                         yourName = a.Name,
                                         ticketNumber = b.TicketID,
                                         movieName = c.MovieName,
                                         showingIn = c.ShowingIn,
                                         showingTime = c.Time,
                                         img = c.Image
                                     }
                                    ).ToList();
                List<DataViewModel> dv = new List<DataViewModel>();
                foreach (var movie in movieBookings)
                {
                    dv.Add(new DataViewModel
                    {
                        MovieName = movie.movieName,
                        TicketID = movie.ticketNumber,
                        ShowingIn = movie.showingIn,
                        Time = movie.showingTime,
                        Image = movie.img

                    });
                }
                ViewBag.BookedMovies = dv;

                var musics = (from a in _db.Registrations
                              join b in _db.MusicTicket
                              on a.RegistrtationID equals b.UserID
                              join c in _db.Musics on b.ActionID equals c.ID
                              where a.ID == getUserID
                              select new
                              {
                                  mName = a.Name,
                                  mticketNumber = b.TicketID,
                                  martist = c.Artist,
                                  mshowingIn = c.ShowingIn,
                                  mshowingTime = c.Time,
                                  img = c.Image


                              }).ToList();

                List<DataViewModel> mv = new List<DataViewModel>();
                foreach (var music in musics)
                {
                    mv.Add(new DataViewModel
                    {
                        Artist = music.martist,
                        TicketID = music.mticketNumber,
                        ShowingIn = music.mshowingIn,
                        Time = music.mshowingTime,
                        Image = music.img

                    });


                };

                ViewBag.music = mv;


                //Sports..........................................................
                var sports = (from a in _db.Registrations
                              join b in _db.BookSportTickets
                              on a.RegistrtationID equals b.UserID
                              join c in _db.Sports on b.ActionID equals c.ID
                              where a.ID == getUserID
                              select new
                              {
                                  //SportName = a.Name,
                                  ticketNumber = b.TicketID,
                                  Name = c.SportName,
                                  showingIn = c.ShowingIn,
                                  showingTime = c.Time,
                                  img = c.Image


                              }).ToList();

                List<DataViewModel> sv = new List<DataViewModel>();
                foreach (var sport in sports)
                {
                    sv.Add(new DataViewModel
                    {
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

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}

