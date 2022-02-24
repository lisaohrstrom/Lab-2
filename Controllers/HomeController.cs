using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieLab.Models;

namespace MovieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var actors = Actor.GetAllActors();
            var movies = Movie.GetAllMovies();
            return View();
        }

        public IActionResult OldMovies () 
        {
            var movies = Movie.GetAllMovies().Where(movie => movie.ReleaseYear < 2000).OrderBy(movie => movie.ReleaseYear).ToList();

            return View(movies);
        }

        public IActionResult RobinWilliamsMovies () 
        {
            // Get all movies with Robin Williams in the ActorList, order oldest first
            var moviesWithRobin = Movie.GetAllMovies().Where(movie => movie.ActorList.Contains("robinwilliams")).OrderBy(movie => movie.Title).ToList();

            return View(moviesWithRobin);
        }

        public IActionResult ThreeActors () 
        {
            // Get all movies with 3 actors, order oldest first
            var moviesWithThreeActors = Movie.GetAllMovies().Where(movie => movie.ActorList.Count == 3).OrderBy(movie => movie.ReleaseYear).ToList();

            return View(moviesWithThreeActors);
        }

        public IActionResult DramaMovies () 
        {
            // Get all movies with 3 actors, ordered newest first
            var dramaMovies = Movie.GetAllMovies().Where(movie => movie.Genre.Contains("Drama")).OrderByDescending(movie => movie.ReleaseYear).ToList();

            return View(dramaMovies);
        }

        public IActionResult SelectedMovie(int Id) 
        {
            var selectedMovie = Movie.GetAllMovies().FirstOrDefault(movie => movie.Id == Id);

            return View(selectedMovie);
        }

        public IActionResult SelectedActor(string Id) 
        {
            var selectedActor = Actor.GetAllActors().FirstOrDefault(actor => actor.Id == Id);

            return View(selectedActor);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
