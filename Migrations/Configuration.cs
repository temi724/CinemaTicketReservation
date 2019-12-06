namespace Easytickets.com.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Easytickets.com.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Easytickets.com.Models.EasyTicketsData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Easytickets.com.Models.EasyTicketsData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.Registrations.AddOrUpdate(x => x.ID,
            //    new Registration()
            //    {
            //        ID = 2,
            //        DateOfRegistration = DateTime.Now,
            //        Email = "temi@gmail.com",
            //        Name = "TeeBoy",
            //        PassWord = "12345",
            //        PhoneNumber = "08106251948",
            //        RegistrtationID = "ET12456",
            //        AdminPass = true
            //    }) ;
            //new Movie()
            //{
            //    ID = 1,
            //    Cost = 5000,
            //    MovieName = "Gemini Man",
            //    ShowingIn = "EasyTickets Cinema",
            //    Time = "MON-FRI(4PM)",
            //    Image = "Images/gemini-man-2019-5k-0w-1536x864.jpg",
            //    Type = "Action",
            //    Date = DateTime.Parse("12/11/2019")

            //}, new Movie()
            //{
            //    ID = 2,
            //    Cost = 5000,
            //    MovieName = "Toy Story4",
            //    ShowingIn = "EasyTickets Cinema",
            //    Time = "MON-FRI(4PM)",
            //    Image = "Images/toy-story-4-new-poster-h5-1536x864.jpg",
            //    Type = "Action",
            //    Date =DateTime.Parse ("13/11/2019")
            //},
            //  new Movie()
            //  {
            //      ID = 4,
            //      Cost = 5000,
            //      MovieName = "Maleficent",
            //      ShowingIn = "EasyTickets Cinema",
            //      Time = "MON-FRI(4PM)",
            //      Image = "Images/maleficent-mistress-of-evil-poster-4k-kz-1536x864.jpg",
            //      Type = "Action",
            //      Date = DateTime.Parse("14/11/2019")
            //  }
            //new Sport() { ID=1, Cost=3000, Date=DateTime.Parse("12/11/2019"), Image= "Images/lionel-messi-fc-art-1m-1536x864.jpg", ShowingIn="EasyTickets Cinema",Time= "MON-FRI(4PM)",SportName="Soccers", Type="LALIGA" },
            //new Sport() { ID = 2, Cost = 3000, Date = DateTime.Parse("13/11/2019"), Image = "Images/kyrie-irving-yz-1536x864.jpg", ShowingIn = "EasyTickets Cinema", Time = "MON-FRI(2PM)", SportName = "Basket Ball", Type = "Championship" },
            //new Sport() { ID = 3, Cost = 3000, Date = DateTime.Parse("14/11/2019"), Image = "Images/boxer-girl-t7-1536x864.jpg", ShowingIn = "EasyTickets Cinema", Time = "MON-FRI(2PM)", SportName = "Boxing", Type = "Championship" },
            //new Sport() { ID = 4, Cost = 2800, Date = DateTime.Parse("14/11/2019"), Image = "Images/tennis-beauty-pic-1366x768.jpg", ShowingIn = "EasyTickets Cinema", Time = "MON-FRI(1PM)", SportName = "Tenis", Type = "Naija Tournament" }
            //  ) ; 
        }
    }
}
