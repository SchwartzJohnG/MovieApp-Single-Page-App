namespace MovieAppSPA.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieAppSPA.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieAppSPA.Infrastructure.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var eric = userManager.FindByName("eric@codercamps.com");
            if (eric == null) {
                eric = new ApplicationUser {
                    UserName = "eric@codercamps.com",
                    Email = "eric@codercamps.com"
                };
                userManager.Create(eric, "Password!1");
            }
        }
    }
}
