namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {

            context.Restaurants.AddOrUpdate(
              p => p.Name,
              new Restaurant { Name = "Chetney", City = "Tempe", Country = "USA" },
              new Restaurant { Name = "Little India", City = "Chandler", Country = "USA" },
              new Restaurant { Name = "Mongolian", City = "Scottsdale", Country = "USA" },
              new Restaurant
              {
                  Name = "Mongolian",
                  City = "Scottsdale",
                  Country = "USA",
                  Reviews = new List<RestaurantReview> {
                      new RestaurantReview { Rating = 9 , Body= "This is the best place on earth" }
                  }
              });

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name, new Restaurant { Name = i.ToString(), City = "Test", Country = "USA" });
            }
        }
    }
}
