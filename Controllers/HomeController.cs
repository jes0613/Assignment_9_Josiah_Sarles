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

        public IActionResult ConfirmAdd()
        {
            
            return View();
        }
        
        public IActionResult FilmList()
        {

            return View(new MovieListViewModel
            {
                movies = _repo.movies
                .OrderBy(p => p.movieID)

            });
        }

        public IActionResult EditFilm(int movieID)
        {
            //pulls the appointment information to then display duing the group form
            var efilm = (from film in _repo.movies
                       where film.movieID == movieID
                       select new Movie()
                       {
                           movieID = film.movieID,
                           category = film.category,
                           title = film.title,
                           year = film.year,
                           director = film.director,
                           rating = film.rating,
                           edited = film.edited,
                           lent = film.lent,
                           notes = film.notes

                       }).ToList();

            ViewBag.Film = efilm;
            return View();
        }

        public IActionResult ConfirmEdit()
        {

            return View();
        }
        public IActionResult ConfirmDelete(int movieID)
        {


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
