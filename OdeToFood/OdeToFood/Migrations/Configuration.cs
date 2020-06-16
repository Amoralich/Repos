namespace OdeToFood.Migrations
{
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
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
			ContextKey = "OdeToFood.Models.ApplicationDbContext";
		}

		protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.
			context.Restaurants.AddOrUpdate(r => r.Name,
new Restaurant { Name = "Marrakesh", City = "D.C", Country = "USA" },
new Restaurant
{
	Name = "The House of Elliot",
	City = "Ghent",
	Country = "Belgium",
	Reviews = new List<RestaurantReview>{new RestaurantReview {Rating = 9, Body = "Great food!", ReviewerName = "Andrus"}
}
});
			for (int i = 0; i < 1000; i++)
			{
				context.Restaurants.AddOrUpdate(r => r.Name, new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
			}
			SeedMembership(context);
		}

		private void SeedMembership(OdeToFood.Models.OdeToFoodDb context)
		{
			if (!context.Roles.Any(r=>r.Name=="Admins"))
			{
				var store = new RoleStore<IdentityRole>(context);
				var manager = new RoleManager<IdentityRole>(store);
				var role = new IdentityRole { Name = "Admins" };
				manager.Create(role);
			}
			if (!context.Users.Any(r=>r.UserName=="kristjan.kivikangur@tthk.ee"))
			{
				var store = new UserStore<ApplicationUser>(context);
				var manager = new UserManager<ApplicationUser>(store);
				var user = new ApplicationUser { UserName = "kristjan.kivikangur@tthk.ee", Email= "kristjan.kivikangur@tthk.ee", BirthDate=new DateTime(1979,8,22) };
				manager.Create(user,"Parool11.");
				manager.AddToRole(user.Id, "Admins");
			}
		}
	}
}
