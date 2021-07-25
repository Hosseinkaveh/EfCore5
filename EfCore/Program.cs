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


            List<Order> orders = new List<Order>();

            for (int i = 0; i < 300; i++)
            {
                orders.Add(
                    new Order
                    {
                        date = DateTime.Now
                    });
            }
            context.orders.AddRange(orders);
            context.SaveChanges();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
