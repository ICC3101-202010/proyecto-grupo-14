using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Playlist
    {
        private int UserId { get; set; }
        private string Name { get; set; }
        private bool Private { get; set; }
        private int Duration { get; set; }

        public Playlist(int UserId,string name, bool @private, int duration)
        {
            this.UserId = UserId;
            this.Name = name;
            Private = @private;
            Duration = duration;


        }
        public Playlist() { }

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
