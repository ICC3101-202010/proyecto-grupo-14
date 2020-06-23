
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Playlist_movie : Playlist
    {
        public List<Movie> Movies = new List<Movie>();
        public string Name { get; set; }
        public bool @Private {get;set;}
        public int Duration { get; set; }
        public Playlist_movie(int UserId, string name, bool @private, int duration, List<Movie> movies):base(UserId,name,@private,duration)
        {
            Movies = movies;
            Name = name;
            @Private = @private;
            Duration = duration;
        }

    }
}