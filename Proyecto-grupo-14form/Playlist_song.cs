using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Playlist_song : Playlist
    {
        public List<Song> Songs = new List<Song>();
        public string Name { get; set; }
        public bool @Private { get; set; }
        public int Duration { get; set; }
        
        public Playlist_song(int UserId, string name, bool @private, int duration, List<Song> songs) : base(UserId, name, @private, duration)
        {
            Songs = songs;
            Name = name;
            @Private = @private;
            Duration = duration;
            
        }

        
    }
}