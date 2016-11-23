using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

       
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
  
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList(); //this will load the movies list right now
            return View(movies);
        }






    }
}