using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using KiteSurfingFinalProject.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KiteSurfingFinalProject.DAL
{
    public class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }




    }
}