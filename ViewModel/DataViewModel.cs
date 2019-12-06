using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easytickets.com.ViewModel
{
    public class DataViewModel
    {
        public int ID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string ShowingIn { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Image { get; set; }
        public decimal Cost { get; set; }
        public string Genre { get; set; }

        public string MovieName { get; set; }
        // public string Artist { get; set; }

        public string Type { get; set; }
        public string SportName { get; set; }
        //public string Artist { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string RegistrtationID { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public string UserID { get; set; }

        public int ActionID { get; set; }
        public string TicketID { get; set; }

    }
}