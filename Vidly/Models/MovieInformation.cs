using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieInformation
    {
        public int id { get; set; }
        public DateTime ReleasedDate { get; set; }

        public DateTime DateAdded { get; set; }

        public int NumberInStock { get; set; }
    }
}