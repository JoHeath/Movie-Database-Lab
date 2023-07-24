using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        //constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
    }
}
