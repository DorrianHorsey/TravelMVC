namespace TravelMVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelMVC.Models.TravelMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TravelMVC.Models.TravelMVCContext context)
        {

           context.Reviews.AddOrUpdate(x => x.ReviewID,
             new Review() { ReviewID = 1, TravelerName= "Dorrian", Destination = "Cedar Point", Title = "Thrill of a lifetime!", Description = "Best roller coasters in the midwest...my family loved it!", ReviewDate = DateTime.Now, CategoryID = 2 },
             new Review() { ReviewID = 2, TravelerName = "Hope", Destination = "Great Wolf Lodge", Title = "Wet and wild fun!", Description = "What a great way to get away for a weekend. All inclusive.", ReviewDate = DateTime.Now, CategoryID = 1 },
             new Review() { ReviewID = 3, TravelerName = "Avalon", Destination = "Columbus Zoo", Title = "Best zoo in Ohio!", Description = "Our family has been coming here for generations. Always fun to explore.  My kids loved petting the stingrays!", ReviewDate = DateTime.Now, CategoryID = 3 },
             new Review() { ReviewID = 4, TravelerName = "Allen", Destination = "Kings Island", Title = "Worth the drive!", Description = "Drove four hours and stayed at local hotel for spring break getaway. Great park.", ReviewDate = DateTime.Now, CategoryID = 2 },
             new Review() { ReviewID = 5, TravelerName = "Cameron", Destination = "Kalahari", Title = "Clean rooms and amazing variety of water rides!", Description = "Had our family reunion here to bring young cousins together- great time had by all ages!", ReviewDate = DateTime.Now, CategoryID = 1 },
             new Review() { ReviewID = 6, TravelerName = "Ruth", Destination = "Cincinnati Zoo", Title = "Lions and Tigers and Bears- oh my!", Description = "Worth the drive from Cleveland to see something different from our local zoo!", ReviewDate = DateTime.Now, CategoryID = 3 });

            context.Categories.AddOrUpdate(x => x.CategoryID,
            new Category() { CategoryID = 1, Attraction = "Water Park" },
            new Category() { CategoryID = 2, Attraction = "Amusement Park" },
            new Category() { CategoryID = 3, Attraction = "Zoo" });





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
        }
    }
}
