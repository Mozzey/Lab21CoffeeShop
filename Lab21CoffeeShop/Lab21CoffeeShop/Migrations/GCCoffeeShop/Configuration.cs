namespace Lab21CoffeeShop.Migrations.GCCoffeeShop
{
    using Lab21CoffeeShop.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab21CoffeeShop.DAL.CoffeeShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\GCCoffeeShop";
        }

        protected override void Seed(Lab21CoffeeShop.DAL.CoffeeShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(new User
            {
                UserID = 1,
                FirstName = "Mike",
                LastName ="Cacciano",
                Email = "mike@gmail.com",
                PhoneNumber = 1231231234,
                Password = "password",
                ConfirmPassword = "password",
                Coffee = "Black"
            });
            context.Users.AddOrUpdate(new User
            {
                UserID = 2,
                FirstName = "Mike",
                LastName = "Cacchiano",
                Email = "mike@gmail.com",
                PhoneNumber = 1234567890,
                Password = "password1",
                ConfirmPassword = "password1",
                Coffee = "Regular"
            });
            context.Users.AddOrUpdate(new User
            {
                UserID = 3,
                FirstName = "Mike",
                LastName = "Cacchiano",
                Email = "mike@gmail.com",
                PhoneNumber = 1231231234,
                Password = "password2",
                ConfirmPassword = "password2",
                Coffee = "Light and Sweet"
            });
            context.SaveChanges();

            
        }
    }
}
