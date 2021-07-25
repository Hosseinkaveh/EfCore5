﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = .\SQL2019;Initial Catalog=EntitiFrameWorkCoreCourse;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.category)
            //    .WithMany(p => p.products)
            //    .HasForeignKey(p => p.FK_CategoryId);

            modelBuilder.Entity<Category>()
                .HasMany(p => p.products)
                .WithOne(p => p.category)
                .HasForeignKey(p => p.FK_CategoryId);
        }
    }
}
