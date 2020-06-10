using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Playlist
    {
        private string name { get; set; }
        private bool Private { get; set; }
        private int Duration { get; set; }

        public Playlist(string name, bool @private, int duration)
        {
            this.name = name;
            Private = @private;
            Duration = duration;


        }

        public void Add()
        {

        }
        public void AddFavSong()
        {

        }
        public void AddFavMovie()
        {

        }
        public void Getinfo()
        {

        }
    }
}
