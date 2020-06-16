using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{   [Serializable]
    public class Artist : Person
    {

        public string Instrument;
        List<string> Discography = new List<string>();

        public Artist(string name, int age, string sex, DateTime dob, DateTime dod, string instrument, List<string> discography) : base(name, age, sex, dob, dod)
        {
            this.Instrument = instrument;
            this.Discography = discography;
        }
        public Artist() {}

    }
}