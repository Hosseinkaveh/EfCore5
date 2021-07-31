using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //QuetyFillter(context);

            EnumerableandQueryable(context);

            Console.ReadLine();
        }

        private static void EnumerableandQueryable(DataContext context)
        {
            //var user = context.users.AsEnumerable();
            //var fillter = user.Where(p => p.Email.Contains("M")); //not working
            //var result = fillter.ToList();

            var user = context.users.AsQueryable();
            var fillter = user.Where(p => p.Email.Contains("M")); //working
            var result = fillter.ToList();
        }

        private static void QuetyFillter(DataContext context)
        {
            var user = context.users.ToList(); //with query filter
            var user1 = context.users.IgnoreQueryFilters().ToList();
        }


    }
}
