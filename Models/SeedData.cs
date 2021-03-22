using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_9_Josiah_Sarles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//SeedData.cs provides the logic for populating the database initially, if needed. 

namespace Assignment_9_Josiah_Sarles.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            MoviesDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<MoviesDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(

                    new Movie
                    {
                        category = "Action / Adventure",
                        title = "Avengers, The",
                        year = 2012,
                        director = "Joss Whedon",
                        rating = "PG-13"
                    }

                );

                context.SaveChanges();
            }
        }
    }
}

