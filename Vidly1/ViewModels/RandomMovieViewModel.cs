using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly1.Models;

namespace Vidly1.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
        public Movie Movie { get; internal set; }
    }
}