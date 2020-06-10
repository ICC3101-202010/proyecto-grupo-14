using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    [Serializable]
    public class Song : Media
    {
        public string filename { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
        public  string Lyrics { get; set; }
        
        public Song(string Filepath, string Filename, long Length, int Releasedate, string Quality, string Genre, string Type, long FileSize, string Description, int Rating, int Views, DateTime DateAdded, string Studio, int Likes, string artist, string album, string Lyrics):base(Filepath, Filename, Length, Releasedate, Quality, Genre, Type, FileSize, Description, Rating, Views, DateAdded, Studio, Likes)
        {
            this.artist = artist;
            this.album = album;
            this.Lyrics = Lyrics;
        }
        public Song() { }
    }
    
  
}