using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesTurtle.Data;
using System;
using System.Linq;

namespace RazorPagesTurtle.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesTurtleContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesTurtleContext>>()))
            {
                // Look for any movies.
                if (context.Turtle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Turtle.AddRange(
                    new Turtle
                    {
                        TurtleName = "FlubbaDubba",
                        ReleaseDate = DateTime.Parse("1949-8-24"),
                        Type = "Tortoise",
                        Price = 232.00M
                    },

                    new Turtle
                    {
                        TurtleName = "Chimichanga",
                        ReleaseDate = DateTime.Parse("2015-12-24"),
                        Type = "Sea Turtle",
                        Price = 125.50M
                    },

                    new Turtle
                    {
                        TurtleName = "Swim",
                        ReleaseDate = DateTime.Parse("2018-11-27"),
                        Type = "Sea Turtle",
                        Price = 58.98M
                    },

                    new Turtle
                    {
                        TurtleName = "Boxer",
                        ReleaseDate = DateTime.Parse("2020-1-1"),
                        Type = "Western Box Turtle",
                        Price = 15.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}