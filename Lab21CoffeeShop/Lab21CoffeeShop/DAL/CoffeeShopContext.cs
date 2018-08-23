using Lab21CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab21CoffeeShop.DAL
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext() : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ItemModel> Items { get; set; }
    }
}