using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var viewResult = new ViewResult();

            ViewResult.ViewData.Model
            return View(movie);

        //These are Action Results Outcomes of Actions
            //return View(movie);  //Returns a view   
            //return Content("Hello World"); //Returns text
            // return HttpNotFound(); //returns 404 error
            //return new EmptyResult(); //returns empty result
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" }); //passing through parameters
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            return Content(String.Format("pageIndex{0}&sortBy={1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}