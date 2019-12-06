using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Easytickets.com.Models
{
    public class EasyTicketsData:DbContext
    {
        public EasyTicketsData() : base("EasyTicketsData") { }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<BookedTicket> BookedTickets { get; set; }
        public DbSet<MusicTicket> MusicTicket{ get; set; }
        public DbSet<BookSportTicket> BookSportTickets { get; set; }


    }
}