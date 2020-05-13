using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    public class Actor : Person
    {
        List<Movie> MoviesWorked = new List<Movie>();

        public Actor(string name, int age, string sex, DateTime dob, DateTime dod, List<Movie> Movies) : base (name, age, sex, dob, dod)
        {
            this.MoviesWorked = Movies;
        }
    }
}
