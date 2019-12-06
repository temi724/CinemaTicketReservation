using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// This class contains fields for the sport information
/// </summary>
namespace Easytickets.com.Models
{
    public class Sport
    {
        public int ID { get; set; }
        public string SportName { get; set; }
        //public string Artist { get; set; }
        public string ShowingIn { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Image { get; set; }
        public decimal Cost { get; set; }
        public string Type { get; set; }

    }
}