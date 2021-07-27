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
            //modelBuilder.Entity<Order>()
            //    .Property(p => p.orderStatus)
            //    .HasConversion(p => p.ToString(), p => (orderStatus)Enum.Parse(typeof(orderStatus), p));

            //or

            modelBuilder.Entity<Order>()
               .Property(p => p.orderStatus)
               .HasConversion(new ValueConverter<orderStatus, string>(p => p.ToString(), p => (orderStatus)Enum.Parse(typeof(orderStatus), p)));


            modelBuilder.Entity<User>()
              .Property(p => p.Email)
              .HasConversion(p => Base64Encode(p), p => Base64Decode(p));

        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
