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
            string targetpath = Path.Combine(Environment.CurrentDirectory, @"Songs\", filename);
            File.Copy(sourcepath, targetpath, true);
            string Quality = "High";
            string type = new FileInfo(targetpath).Extension;
            long length = 3000;
            long size = new FileInfo(targetpath).Length;
            string Description = "";
            if (richtextboxdescription.Text != null)
            {
                Description = richtextboxdescription.Text;
            }
            string Lyrics = "";
            if (richtextboxLyrics.Text != null)
            {
                Lyrics = richtextboxLyrics.Text;
            }
            int rating = 0;
            int Views = 0;
            DateTime added = DateTime.Now;
            string Studio = "";
            if (textboxstudio.Text != null)
            {
                Studio = textboxstudio.Text;
            }
            int likes = 0;
            string artist = "Fco";
            string album = "Album nuevo";
            int release = 0;
            if (textboxreleased.Text != null)
            {
                release = Convert.ToInt32(textboxreleased.Text);
            }
            string genre = "";
            if (textboxgenre.Text != null)
            {
                genre = textboxgenre.Text;
            }

            Song s = new Song(targetpath, filename, length, release, Quality, genre, type, size, Description, rating, Views, added, Studio, likes, artist, album, Lyrics);
            manda.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textboxgenre.Clear();
            textboxreleased.Clear();
            textboxstudio.Clear();
            richtextboxdescription.Clear();
            richtextboxLyrics.Clear(); 
         
            

        }
        
        public Song sendSong
        {

            get
            {
                return manda[0];
            }
        }

        private void ImportSong_Load(object sender, EventArgs e)
        {

        }

        private void textboxreleased_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
