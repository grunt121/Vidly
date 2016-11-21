using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.ViewModels;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>          //Creates a new list and adds items to it
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel //As you are using a view model you need to add this information in 
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
            
        }

        public ActionResult MovieList()
        {
            var movieList = new List<Movie>
            {
                new Movie {Name= "Shrek" },
                new Movie {Name= "Its a wonderful Life" }
            };


            var viewModel = new MovieViewModel //As you are using a view model you need to add this information in 
            {
                Movies = movieList
     
            };
  
            return View(viewModel);

        }


    }
}