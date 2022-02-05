﻿using Microsoft.EntityFrameworkCore;

namespace ProductRegistrationAndListing.Models
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProductRegisterAndList; Trusted_Connection=true");
        }
    }
}
