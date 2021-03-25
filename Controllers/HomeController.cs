using Assignment_9_Joisah_Sarles.Models.ViewModels;
using Assignment_9_Josiah_Sarles.Models;
using Assignment_9_Josiah_Sarles.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //variables for the database
        private IMoviesRepo _repo;
        public int PageSize = 20;
        private MoviesDbContext _context { get; set; }


        //Sets the variables to be used in the controller
        public HomeController(ILogger<HomeController> logger, IMoviesRepo repo, MoviesDbContext con)
        {
            _logger = logger;
            _repo = repo;
            _context = con;
        }


        //Returns the index page
        public IActionResult Index()
        {
            return View();
        }


        // Returns the Podcasts view
        public IActionResult Podcasts()
        {
            return View();
        }

        // On get, the EnterFilm view is return for a user to enter
        // a new film to add to the database
        [HttpGet]
        public IActionResult EnterFilm()
        {
                return View();
        }


        // On post, if the user has added all the required
        // information to the form to enter a film, then the new record is added to
        // the database. 
        [HttpPost]
        public IActionResult EnterFilm(Movie m)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(m);
                _context.SaveChanges();
                return View("ConfirmAdd", m);
            }
            else
            {
                return View();
            }

        }
        
        // Lists 20 films in the database at a time. I added all the films currently in the collection from
        // the google sheet. There is also pagination so that the user can see all the other movies.
        // I included a current category variable for future implementation of a category filter.
        public IActionResult FilmList(string category, int pageNum = 1)
        {

            return View(new MovieListViewModel
            {
                movies = _repo.movies
                    .Where(p => category == null || p.category == category)
                    // Here I used OrderByDescending so that when a movie is added to the database
                    // it shows up first in the list of movies
                    .OrderByDescending(p => p.movieID)
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize)
                ,

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repo.movies.Count() :
                        _repo.movies.Where(x => x.category == category).Count()
                },
                CurrentCategory = category

            });
        }

        // this controller action allows for sending a movie object to the EditFilm view insted of the movieID,
        // this makes it easier to fill show the user in the Eidt film view what is in the current record to be edited
        public IActionResult RedirectToEdit(int movieID)
        { 
            Movie m = _context.Movies.FirstOrDefault(p => p.movieID == movieID);

            return View("EditFilm", m);
        }


        // On post, the controller checks to make sure that the user imputted all the required fields in the form
        // then it takes what the user inputted and edits the movie record. 
        // If there were actually edits then the edited variable is change, else the edied vvariable is set to No
        // if the user didn't input data into all the required fields the view refreshes and sends the validation summary
        // then if everything worked the user is sent to the confirmEdit view. 
        [HttpPost]
        public IActionResult EditFilm(Movie eM)
        {
            Movie m = _context.Movies.FirstOrDefault(p => p.movieID == eM.movieID);

            if (ModelState.IsValid)
            {
                m.category = eM.category;
                m.title = eM.title;
                m.year = eM.year;
                m.director = eM.director;
                m.rating = eM.rating;
                m.lent = eM.lent;
                m.notes = eM.notes;

                _context.SaveChanges();

                if (_context.ChangeTracker.HasChanges())
                {
                    m.edited = "Yes";
                    _context.SaveChanges();
                }
                else
                {
                    m.edited = "No";
                    _context.SaveChanges();
                }

            }
            else
            {
                return View(m);
            }

            return View("ConfirmEdit", m);
        }

        // When a movie record is deleted, this controller action deletes it and sends the user to the confirmdelete view
        public IActionResult ConfirmDelete(int movieID)
        {
            Movie m = _context.Movies.FirstOrDefault(p => p.movieID == movieID);
            _context.Remove(m);
            _context.SaveChanges();
            return View(m);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
