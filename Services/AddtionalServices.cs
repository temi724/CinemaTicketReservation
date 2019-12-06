using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Easytickets.com.Models;

namespace Easytickets.com.Services
{
    public class AddtionalServices
    {
         private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);

            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public static string GenerateBookingNumber()
        {
            var id = "";
            EasyTicketsData   _db = new EasyTicketsData();
            System.Text.StringBuilder builder = new StringBuilder();
            builder.Append(RandomNumber(1000, 9999));
            id = "TEM" + builder.ToString();
            var bookingNum = _db.BookedTickets.Where(x => x.TicketID == id).FirstOrDefault();
            if (bookingNum != null)
            {
                builder.Append(RandomNumber(10000, 99999));
                id = "TEM" + builder.ToString();
            }
            return id;
        }

        public static string GenerateRegID()
        {
            var id = "";
            EasyTicketsData _db = new EasyTicketsData();
            System.Text.StringBuilder builder = new StringBuilder();
            builder.Append(RandomNumber(1000, 9999));
            id = "ET" + builder.ToString();
            var regGen = _db.Registrations.Where(x => x.RegistrtationID == id).FirstOrDefault();
            if (regGen!= null)
            {
                builder.Append(RandomNumber(10000, 99999));
                id = "ET" + builder.ToString();
            }
            return id;
        }

       
    }
}