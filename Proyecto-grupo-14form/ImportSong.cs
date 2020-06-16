using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Media;

namespace Proyecto_grupo_14form
{
    public partial class ImportSong : Form
    {
        public List<Song> manda = new List<Song>();
        public ImportSong()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        
    
        
        
        private void Lyrics_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd.Filter="All Supported Audio | *.mp3; *.wma; *.m4a; *.flac; *.wav| MP3s | *.mp3 | WMAs | *.wma";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text = ofd.SafeFileName;
                
                
                
                
                
            }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string sourcepath = textBox1.Text;
            string filename = textBox2.Text;
            string originalpath = Environment.CurrentDirectory;
            int striglen = originalpath.Length;

            string newpath = originalpath.Remove(striglen - 10, 10);
            string folderpath = Path.Combine(newpath, @"Songs\");
            string targetpath = Path.Combine(folderpath, filename);
            File.Copy(sourcepath, targetpath, true);
            string Quality = "High";
            string type = new FileInfo(targetpath).Extension;

            long length = 0;

            long size = new FileInfo(targetpath).Length;
            string Description = "";
            if (ImportSong_DescriptionTextBox.Text != null)
            {
                Description = ImportSong_DescriptionTextBox.Text;
            }
            string Lyrics = "";
            if (ImportSong_LyricsTextBox.Text != null)
            {
                Lyrics = ImportSong_LyricsTextBox.Text;
            }
            int rating = 0;
            int Views = 0;
            DateTime added = DateTime.Now;
            string Studio = "";
            if (ImportSong_StudioTextBox.Text != null)
            {
                Studio = ImportSong_StudioTextBox.Text;
            }
            int likes = 0;
            string artist = "";
            if (ImportSong_ArtistTextBox.Text != null)
            {
                artist = ImportSong_ArtistTextBox.Text;
            }


            string album = "";
            if (ImportSong_AlbumTextBox.Text != null)
            {
                album = ImportSong_AlbumTextBox.Text;
            }

            int release = 0;
            if (ImportSong_ReleaseTextBox.Text != null)
            {
                release = Convert.ToInt32(ImportSong_ReleaseTextBox.Text);
            }
            string genre = "";
            if (ImportSong_GenreTextBox.Text != null)
            {
                genre = ImportSong_GenreTextBox.Text;
            }

            Song s = new Song(targetpath, filename, length, release, Quality, genre, type, size, Description, rating, Views, added, Studio, likes, artist, album, Lyrics);
            MainForm.Songsdata.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            ImportSong_AlbumTextBox.Clear();
            ImportSong_ArtistTextBox.Clear();
            ImportSong_GenreTextBox.Clear();
            ImportSong_ReleaseTextBox.Clear();
            ImportSong_StudioTextBox.Clear();
            ImportSong_DescriptionTextBox.Clear();
            ImportSong_LyricsTextBox.Clear(); 
         
            

        }
        /*
        public Song sendSong
        {

            get
            {
                return manda[0];
            }
        }*/

        private void ImportSong_Load(object sender, EventArgs e)
        {

        }

        private void textboxreleased_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
