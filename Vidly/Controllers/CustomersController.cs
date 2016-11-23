using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ByDetails(int id)
        {
            return Content(id + " Example");
        }


        public ActionResult ListOfCustomers()
        {

            var customers = new List<Customer>          //Creates a new list and adds items to it
            {
                new Customer {Name = "Customer 1", Id=1 },
                new Customer {Name = "Customer 2" , Id=2 }
            };

            var viewModel = new CustomerViewModel //As you are using a view model you need to add this information in 
            {
        
                Customers = customers
            };


            return View(viewModel);
        }
       
    }
}