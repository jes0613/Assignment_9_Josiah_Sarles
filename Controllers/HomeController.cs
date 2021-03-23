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
        private MoviesDbContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, IMoviesRepo repo, MoviesDbContext con)
        {
            _logger = logger;
            _repo = repo;
            _context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterFilm()
        {
                return View();
        }

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
        
        public IActionResult FilmList()
        {

            return View(new MovieListViewModel
            {
                movies = _repo.movies
                .OrderBy(p => p.movieID)

            });
        }

        public IActionResult Redirect(int movieID)
        { 
            Movie m = _context.Movies.FirstOrDefault(p => p.movieID == movieID);

            return View("EditFilm", m);
        }

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
