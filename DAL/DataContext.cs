using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public DbSet<User> users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = .\SQL2019;Initial Catalog=EntitiFrameWorkCoreCourse;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Email = "k.p@gmail.com", Id = 1 });
            modelBuilder.Entity<Order>().HasData(new Order { Id=1,OrderNumber=1,orderStatus=orderStatus.Delivered });

        }
     
    }
}
