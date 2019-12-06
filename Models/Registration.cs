using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easytickets.com.Models
{/// <summary>
/// This class contains the information tha will be requested by a user when they 
/// try to register on easytickets.com
/// </summary>
    public class Registration
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string RegistrtationID { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public bool AdminPass { get; set; }
    }
}