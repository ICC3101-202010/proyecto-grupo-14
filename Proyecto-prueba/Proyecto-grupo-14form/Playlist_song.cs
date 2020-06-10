using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Playlist_song : Playlist
    {
        List<Song> Songs = new List<Song>();
        public Playlist_song(string name, bool @private, int duration, List<Song> songs) : base(name, @private, duration)
        {
            Songs = songs; 
        }
    }
}