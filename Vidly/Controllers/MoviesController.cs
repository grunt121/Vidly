﻿using System;
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
            var movie = _context.Movies.Include(m => m.Genre).ToList();  //this will load the movies list right now
            return View(movie);
        }


        public ActionResult Details(int id)
        {


            var movie = _context.Movies
                .Include(m => m.Genre)
                .Single(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);


        }
    }
}