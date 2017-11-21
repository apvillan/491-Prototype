using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _491_Prototype.Models;
using _491_Prototype.View_Models;

namespace _491_Prototype.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer {name = "Customer 1"},
                new Customer {name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            // Pasing movie into the view.
            // return View(movie)

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if ( String.IsNullOrWhiteSpace(sortBy) )
            {
                sortBy = "Name";
            }

            return Content( String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy) );
        }

        // using multiple parameters using variables
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate ( int year, int month )
        {
            return Content(year + "/" + month);
        }
    }
}