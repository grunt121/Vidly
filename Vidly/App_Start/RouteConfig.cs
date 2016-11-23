using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            /* routes.MapRoute(
                        "MoviesByReleasedDate",
                            "movies/released/{year}/{month}",
                            new { controller = "Movies", action = "ByReleaseDate"},
                            new { year = @"2015|2016", month = @"\d{2}" }); //this is an example of using regular expressions to restrict access 2015 or 2016
                            */

            routes.MapRoute(
                    "CustomerDetails",
                    "customers/details/{id}",
                    new { controller = "Customers", action = "Details" });
                            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
