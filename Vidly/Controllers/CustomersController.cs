using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        //If you are pulling stuff from the data you can do the following
        private ApplicationDbContext _context;
        //Initialize this in the constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //The DbContext is a disposable object which means properly disposing of it
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //this will load all customer in the database adding the to list loads everything right now
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            var customer = _context.Customers
                .Include(c => c.MembershipType)
                .Single(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);


        }



      
        }
       
    }
