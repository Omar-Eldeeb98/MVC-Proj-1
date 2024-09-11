using Microsoft.AspNetCore.Mvc;
using MVC_Proj_1.Models;

namespace MVC_Proj_1.Controllers
{
    public class MoviesController : Controller
    {
        // actions

        //public string getMovies(string id)
        //{
        //    return $"id = {id}";
        //}

        //[ActionName("testzero")]
        public IActionResult getMovies(int? id, string name, Movie movie)
        {
            return Content($"id: {id}", "text/html");
        }

        public IActionResult test1(int? id)
        {
            if (id is null)
            {
                return Redirect("www.google.com");
            }
            else
            {
                return RedirectToAction("getMovies", "Movies", new { id = id });
            }
        }
    }
}