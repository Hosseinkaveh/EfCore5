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
        public DbSet<Order> orders { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = .\SQL2019;Initial Catalog=EntitiFrameWorkCoreCourse;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("orderNumber", "common")
                .StartsAt(1000)
                .IncrementsBy(1)
                .HasMax(int.MaxValue);

            modelBuilder.Entity<Order>()
                .Property(p => p.OrderNumber)
                .HasDefaultValueSql("NEXT VALUE FOR common.orderNumber");

        }
    }
}
