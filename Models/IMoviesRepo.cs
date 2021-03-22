using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles.Models
{
    public interface IMoviesRepo
    {
        IQueryable<Movie> movies { get; }
    }
}
