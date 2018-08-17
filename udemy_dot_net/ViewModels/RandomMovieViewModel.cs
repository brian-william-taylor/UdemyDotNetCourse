using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using udemy_dot_net.Models;

namespace udemy_dot_net.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}