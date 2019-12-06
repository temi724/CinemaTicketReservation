using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easytickets.com.Models
{
    public class Movie
    {

        public int ID { get; set; }
        public string MovieName { get; set; }
        // public string Artist { get; set; }
        public string ShowingIn { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public decimal Cost { get; set; }
        public string Type { get; set; }
    }
}