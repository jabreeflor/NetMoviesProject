


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesListed.Models;
using System.Linq;

namespace MoviesListed.Controllers
{
    public class HomeController : Controller
    {
        private movieContext context { get; set; }

        public HomeController(movieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movie
                .Include(m => m.Lists)
                .OrderBy(m => m.Title)
                .ToList();
            return View(movies);
        }

        public IActionResult About()
        {
            ViewBag.Title = "contact";
            return View();
        }
    }
}