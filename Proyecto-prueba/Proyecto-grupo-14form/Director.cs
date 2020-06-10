using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Director : Person
    {
        List<Movie> Movies_directed = new List<Movie>();
        Director(string name, int age, string sex, DateTime dob, DateTime dod, List<Movie> Movies) : base(name, age, sex, dob, dod)
        {
            this.Movies_directed = Movies;
        }
    }
}
