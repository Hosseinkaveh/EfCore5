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


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
