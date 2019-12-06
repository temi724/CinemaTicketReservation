using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easytickets.com.Models
{
    public class Music
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
    }
}