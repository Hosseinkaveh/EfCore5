using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace EfCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.users.Add(new User
            {
                Email = "k.pouria7@gmail.com"
            });
            context.orders.Add(new Order
            {
                orderStatus = orderStatus.Processing,
                OrderNumber = 1
            });
            context.SaveChanges();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
