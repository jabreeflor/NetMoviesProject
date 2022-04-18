using Microsoft.AspNetCore.Mvc;
using MoviesListed.Models;
using System.Linq;

public class movieController : Controller
{
    private movieContext context { get; set; }

    public movieController(movieContext ctx)
    {
        context = ctx;
    }

    [HttpGet]
    public IActionResult Add()
    {
        ViewBag.Action = "Add";
        ViewBag.Lists = context.Lists.OrderBy(s => s.mTitle).ToList();
        return View("Edit", new Movie());
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        ViewBag.Action = "Edit";
        ViewBag.Lists = context.Lists.OrderBy(s => s.mTitle).ToList();
        var movie = context.Movie.Find(id);
        return View(movie);
    }

    [HttpPost]
    public IActionResult Edit(Movie movie)
    {
        if (ModelState.IsValid)
        {
            if (movie.MovieId == 0)
                context.Movie.Add(movie);
            else
                context.Movie.Update(movie);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        else
        {
            ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
            ViewBag.Lists = context.Lists.OrderBy(s => s.mTitle).ToList();
            return View(movie);
        }
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var movie = context.Movie.Find(id);
        return View(movie);
    }

    [HttpPost]
    public IActionResult Delete(Movie movie)
    {
        context.Movie.Remove(movie);
        context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
}
