using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Easytickets.com.Models;

namespace Easytickets.com.Models
{/// <summary>
/// This class contains the information of already booked ticket....
/// </summary>
    public class BookedTicket
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int ActionID { get; set; }
        public string TicketID { get; set; }

    }
}