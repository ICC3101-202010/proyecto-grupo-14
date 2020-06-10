using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proyecto_grupo_14form
{
    public partial class Form1 : Form
    {
        private ImportSong ImportSong;
        private MediaPlayer MediaPlayer;
        public List<Movie> Moviesdata = new List<Movie>();
        public List<Song> Songsdata = new List<Song>();
        Controlador a = new Controlador();
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
            ImportSong = new ImportSong();
            MediaPlayer = new MediaPlayer();

        }
        private void CustomizeDesign()
        {
            panelmedia.Visible = false;
            panelplaylist.Visible = false;
            panelprofile.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelmedia.Visible == true)
                panelmedia.Visible = false;
            if (panelplaylist.Visible == true)
                panelplaylist.Visible = false;
            if (panelprofile.Visible == true)
                panelprofile.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void Deserializesongs()
        {
            try
            {
                if (File.Exists("Songsdata.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(Songsdata.GetType());
                    using (StreamReader sr = new StreamReader("Songsdata.xml"))
                    {
                        Songsdata = (List<Song>)serializer.Deserialize(sr);
                    }
                }
                else throw new FileNotFoundException("File not found");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Serializesongs()
        {
            try
            {

                
                // Creates XmlSerializer of the List<User> type
                //XmlSerializer serializer = new XmlSerializer(Songsdata.GetType());

                // An alternative syntax could also be:
                XmlSerializer serializer = new XmlSerializer(typeof(List<Song>));

                // Creates a stream using which we'll serialize
                using (StreamWriter sw = new StreamWriter("Songsdata.xml"))
                {
                    // We call the Serialize() method and pass the stream created above as the first parameter
                    // The second parameter is the object which we want to serialize
                    serializer.Serialize(sw, Songsdata);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void NuevaCancion(string Filepath, string Filename, long Length, DateTime Realsedate, string Quality, string Genre, string Type, int FileSize, string Description, int Rating, int Views, DateTime DateAdded, string Studio, int Likes, object artist, string album, string Lyrics)
        {
            
            Songsdata.Add(ImportSong.sendSong);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Deserializesongs();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializesongs();
        }

        private void Media_Click(object sender, EventArgs e)
        {
            showSubMenu(panelmedia);
        }
        //Sub_menu_de_media
        private void button2_Click(object sender, EventArgs e)
        {
            // codes..
            openChildform(ImportSong);
            
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Songsdata.Add(ImportSong.sendSong);
            //code..
            
            

            
            foreach(Song i in Songsdata)
            {
                richTextBox1.Text += i.filename;
                richTextBox1.Text += "si hay canciones en la lista";
            }
            hidesubmenu();
        }

        private void Mediasubmenu_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void PlaylistManagment_Click(object sender, EventArgs e)
        {
            showSubMenu(panelplaylist);
        }
        //submenu de playlist
        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            showSubMenu(panelprofile);
        }
        //submenu de profile
        private void button10_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private Form activeForm = null;
        private void openChildform(Form childform)
        {
            if (activeForm != null)
                
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childform);
            panelChildform.Tag = childform;
            childform.BringToFront();
            childform.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //code..
            
            

            foreach (Song i in Songsdata)
            {
                richTextBox1.Text += i.album;
                richTextBox1.Text += "\n";
                richTextBox1.Text += i.Lyrics;
                richTextBox1.Text += "\n"; 
                richTextBox1.Text += "si hay canciones en la lista";
            }
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            openChildform(MediaPlayer);
            Songsdata[0].Play(MediaPlayer);
            
        }
    }
}
