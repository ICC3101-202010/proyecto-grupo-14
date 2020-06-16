
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Playlist_movie : Playlist
    {
        List<Movie> Movies = new List<Movie>();

        public Playlist_movie(string name, bool @private, int duration, List<Movie> movies):base(name,@private,duration)
        {
            Movies = movies;
        }
    }
}