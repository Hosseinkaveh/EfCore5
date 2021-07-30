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

            // ShowQueryString(context);
            // eagerLoading(context);

            ExplicitLoading(context);

            Console.ReadLine();
        }

        private static void ExplicitLoading(DataContext context)
        {
            var user = context.users.Where(p => p.Id == 1).FirstOrDefault();
            if (true)
            {
                context.Entry(user).Collection(p => p.comments).Load();//one to many

                context.Entry(user).Reference(p => p.Image).Load();//many to one

                context.Entry(user)
                    .Collection(p => p.comments)
                    .Query()
                    .Where(p => p.CmText.Contains("M"))
                    .Load();//Queary
            }
        }

        private static void eagerLoading(DataContext context)
        {
            var UserAndCm = context.users
                .Include(p => p.comments.Where(x => x.UserId == 1)).ToString();

            var UserAndCm1 = context.users.
                Include(p => p.comments.Where(x => x.UserId == 1))
                .AsSplitQuery().ToString();

            var UserAndImage = context.users.Include(p => p.Image).ToList();
        }

        private static void ShowQueryString(DataContext context)
        {
            var query = context.users.TagWith("This is comment for queary").ToQueryString();
            Console.WriteLine(query);
        }

    }
}
