using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles.Models
{
    public class MoviesDbContext : DbContext
    {

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; } //sets up a table for movies in the databases
    }
}
