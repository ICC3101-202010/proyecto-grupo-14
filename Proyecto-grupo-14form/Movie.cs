using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_grupo_14form
{
    public class Movie : Media
    {
        public string Filename { get; set; }
        public string Category { get; set; }
        public object Director { get; set; }

        public Movie(string Filepath, string Filename, long Length, int Releasedate, string Quality, string Genre, string Type, long FileSize, string Description, int Rating, int Views, DateTime DateAdded, string Studio, int Likes, string Category, object Director) : base(Filepath, Filename, Length, Releasedate, Quality, Genre, Type, FileSize, Description, Rating, Views, DateAdded, Studio, Likes)
        {
            this.Filename = Filename;
            this.Category = Category;
            this.Director = Director;
        }

        public Movie() { }
    }
}
