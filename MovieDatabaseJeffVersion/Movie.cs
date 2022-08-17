using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseJeffVersion
{
    internal class Movie
    {
        //Each individual movie needs its own Title an its own Category.
        //Therefore we do *not* make these static.
        public string Title;
        public string Category;

        public Movie(string _Title, string _Category)
        {
            Title = _Title;
            Category = _Category;
        }

        public override string ToString()
        {
            return $"{Title} ({Category})";
        }
    }
}
