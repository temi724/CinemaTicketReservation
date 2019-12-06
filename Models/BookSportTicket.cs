using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easytickets.com.Models
{
    public class BookSportTicket
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int ActionID { get; set; }
        public string TicketID { get; set; }
    }
}