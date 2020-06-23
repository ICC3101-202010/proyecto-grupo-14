using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_grupo_14form
{
    public partial class Create_Playlist : Form
    {
        public delegate void pasarm(Playlist_movie movie);
        public delegate void pasars(Playlist_song song);
        public event pasarm pasadom;
        public event pasars pasados;
        public Create_Playlist()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string type = comboBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            bool priv = Privacidad.Checked;
            
            if (type == "Song")
            {
                List<Song> songs = new List<Song>();
                Playlist_song p = new Playlist_song(0, name, priv, 0, songs);
                pasados(p);
                textBox1.Clear();
                Privacidad.Checked = false;
            }
            else
            {
                List<Movie> movies = new List<Movie>();
                Playlist_movie m = new Playlist_movie(0, name, priv,0 , movies);
                pasadom(m);
                textBox1.Clear();
                Privacidad.Checked = false;
            }
            
            

        }

        private void Privacidad_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
