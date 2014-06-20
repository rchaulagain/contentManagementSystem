namespace CMS.Database.Migrations
{
    using CMS.data.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CMS.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CMS.Database.ApplicationDbContext context)
        {
            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Contact
                {
                    Id = 1,
                    FirstName = "Cavin",
                    LastName = "cavin",
                    Address1 = "175 N IndianHill ",
                    Address2 = "Blvd",
                    PhoneNumber = "543454",
                    Company = "WCPS HOLDING",
                    Title = "DEV",
                    City = "Sacramento",
                    State = "California"
                });
        }
    }
}
