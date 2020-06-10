using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_grupo_14form
{
    public class Controlador
    {

        public void GiveRating(int rating, object Media)
        {
            //Media.Rating += rating;
        }
        public void Search(string search)
        {

        }
        public void AddFavVideo()
        {

        }
        public void AddFavSong()
        {

        }
        public void ImportVideo(string fileName, string sourcePath)
        {
            
        }
        public void ImportSong(string fileName, string sourcePath)
        {
            string targetPath = Path.Combine(Environment.CurrentDirectory, "@Songs");
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            File.Copy(sourceFile, destFile, true);
            
        }
        public void Follow(string s)
        {

        }
    }

}
