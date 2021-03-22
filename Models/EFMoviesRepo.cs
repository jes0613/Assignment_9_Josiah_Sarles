using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles.Models
{
    public class EFMoviesRepo : IMoviesRepo

    {
        private MoviesDbContext _context;

        public EFMoviesRepo(MoviesDbContext context)
        {
            _context = context;
        }

        public MoviesDbContext GetContext()
        {
            return _context;
        }

        public IQueryable<Movie> movies => _context.Movies;
    }
}
