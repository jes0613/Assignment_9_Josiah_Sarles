using Assignment_9_Joisah_Sarles.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles.Models.ViewModels
{
    public class MovieListViewModel
    {
        // This Model makes it easy to print out all the movies
        public IEnumerable<Movie> movies { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
