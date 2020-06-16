using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Actor : Person
    {
        List<Movie> MoviesWorked = new List<Movie>();

        Actor(string name, int age, string sex, DateTime dob, DateTime dod, List<Movie> Movies) : base(name, age, sex, dob, dod)
        {
            this.MoviesWorked = Movies;
        }
    }
}
