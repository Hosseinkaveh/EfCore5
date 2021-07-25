using Entities;
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
        public DbSet<Order> orders { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = .\SQL2019;Initial Catalog=EntitiFrameWorkCoreCourse;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedNever();

            modelBuilder.Entity<Product>()
                .Property(p => p.Id)
                .UseIdentityColumn(1000, 2);

            modelBuilder.Entity<Product>()
                .Property(p => p.Createtime)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Product>()
                .Property(p => p.Score)
                .HasDefaultValue(100);

            //code-2021
            modelBuilder.Entity<Order>()
                .Property(p => p.OrderNumber)
                .HasComputedColumnSql("'code-' + Cast(Year(getdate()) As varchar)");



        }
    }
}
