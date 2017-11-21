using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _491_Prototype.Models;

namespace _491_Prototype.View_Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}