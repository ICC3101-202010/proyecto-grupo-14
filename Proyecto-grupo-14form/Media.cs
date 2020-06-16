using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_grupo_14form
{
    [Serializable]
    public class Media
    {
        private string FileName { get; set; }
        private long Length;
        private int ReleaseDate;
        private string Quality;
        private string Genre;
        private string Type;
        private long FileSize;
        private string Description;
        private int Rating;
        private int Views;
        private DateTime DateAdded;
        private string Studio;
        private int Likes;
        private string filepath;

        public Media(string filepath, string filename, long length, int releasedate, string quality, string genre, string type, long fileSize, string description, int rating, int views, DateTime dateAdded, string studio, int likes)
        {
            this.filepath = filepath;
            FileName = filename;
            Length = length;
            this.ReleaseDate = releasedate;
            Quality = quality;
            Genre = genre;
            Type = type;
            FileSize = fileSize;
            Description = description;
            Rating = rating;
            Views = views;
            DateAdded = dateAdded;
            Studio = studio;
            Likes = likes;
        }

        public Media() {}

        public virtual void Play(MediaPlayer mediaPlayer)
        {
            mediaPlayer.axWindowsMediaPlayer1.URL = this.filepath;
        }
        public virtual void Stop()
        {

        }
        public virtual void Next()
        {

        }
        public virtual void Comment()
        {

        }
        public virtual void Add_icon()
        {

        }
    }
}