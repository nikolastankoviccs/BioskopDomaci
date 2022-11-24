using BioskopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioskopMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = Details();
            return View(movies);
        }

        public IEnumerable<Movie> Details()
        {
            List<Movie> movies = new List<Movie> {
                new Movie
                {
                    Id=1,
                    Name="Harry Potter",
                    Director = "Kris Kolambus",
                    ProjectionTime = new DateTime(2022,11,22,18,45,00)
                },new Movie
                {
                    Id=2,
                    Name="Gospodar prstenova",
                    Director = "Piter Jackson",
                    ProjectionTime = new DateTime(2022,11,22,22,00,00)
                }
            };

            return movies;
        
        }
        public ActionResult GetMovie(int id)
        {
            var movie = Details().SingleOrDefault(q => q.Id == id);
            return View(movie);
        }
    }
}