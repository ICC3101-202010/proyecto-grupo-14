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
using WMPLib;
using AxWMPLib;

namespace Proyecto_grupo_14form
{
    public partial class MainForm : Form
    {
        
        private ImportSong ImportSong;
        private ImportMovie ImportMovie;
        private MediaPlayer MediaPlayer;
        private YouTube YouTube;
        private Playlists Playlists;
        private Create_Playlist Create;
        private Library Library;
        public static List<Movie> Moviesdata = new List<Movie>();
        public static List<Song> Songsdata = new List<Song>();
        Controlador a = new Controlador();
        public MainForm()
        {
            InitializeComponent();
            foldersongs();
            CustomizeDesign();
            Deserializesongs();
            
            ImportSong = new ImportSong();
            ImportMovie = new ImportMovie();
            MediaPlayer = new MediaPlayer();
            Create = new Create_Playlist();
            Playlists = new Playlists(Create);
            Library = new Library();
            YouTube = new YouTube();
            
            

            ListBox mylist = new ListBox();
            
            mylist.Dock = DockStyle.Fill;
            mylist.BackColor = Color.RoyalBlue;
            mylist.Font = new Font("Georgia", 16);
            mylist.ForeColor = Color.White;
            mylist.Size = new Size(808, 610);
            mylist.BorderStyle = BorderStyle.Fixed3D;


            try
            {
                foreach (Song i in Songsdata) {
                    mylist.Items.Add(i.filename);
                        }
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
            

            Library.Controls.Add(mylist);
            


        }
        private void CustomizeDesign()
        {
            panelmedia.Visible = false;
            panelplaylist.Visible = false;
            panelprofile.Visible = false;
            Searchpanel.Visible = false;
        }
        private void Mediaplaying()
        {

        }
        private void hidesubmenu()
        {
            if (panelmedia.Visible == true)
                panelmedia.Visible = false;
            if (panelplaylist.Visible == true)
                panelplaylist.Visible = false;
            if (panelprofile.Visible == true)
                panelprofile.Visible = false;
            if (Searchpanel.Visible == true)
                Searchpanel.Visible = false;
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
        private void foldersongs()
        {
            string originalpath = Environment.CurrentDirectory;
            int striglen = originalpath.Length;
            string newpath = originalpath.Remove(striglen - 10, 10);
            string foldermovies = Path.Combine(newpath, @"Movies\");
            string folderpath = Path.Combine(newpath, @"Songs\");
            string Songsdatapath = Path.Combine(newpath, @"Songsdata.xml");
            string Moviesdatapath = Path.Combine(newpath, @"Moviesdata.xml");
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);

            }
            if (!Directory.Exists(foldermovies))
            {
                Directory.CreateDirectory(foldermovies);

            }
            if (!File.Exists(Moviesdatapath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(Moviesdatapath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            if (!File.Exists(Songsdatapath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(Songsdatapath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }




        }
        private void Deserializesongs()
        {
            string originalpath = Environment.CurrentDirectory;
            int striglen = originalpath.Length;
            string newpath = originalpath.Remove(striglen - 10, 10);
            try
            {
                string Songsdatapath = Path.Combine(newpath, @"Songsdata.xml");
                if (File.Exists(Songsdatapath))
                {
                    XmlSerializer serializer = new XmlSerializer(Songsdata.GetType());
                    using (StreamReader sr = new StreamReader(Songsdatapath))
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
            string originalpath = Environment.CurrentDirectory;
            int striglen = originalpath.Length;
            string newpath = originalpath.Remove(striglen - 10, 10);
            
            try
            {

                string Songsdatapath = Path.Combine(newpath, @"Songsdata.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(List<Song>));

                // Creates a stream using which we'll serialize
                using (StreamWriter sw = new StreamWriter(Songsdatapath))
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
        /*
        private void NuevaCancion(string Filepath, string Filename, long Length, DateTime Realsedate, string Quality, string Genre, string Type, int FileSize, string Description, int Rating, int Views, DateTime DateAdded, string Studio, int Likes, object artist, string album, string Lyrics)
        {
            
            Songsdata.Add(ImportSong.sendSong);
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            openChildform(ImportMovie);
            

            
           
            hidesubmenu();
        }

        private void Mediasubmenu_Click(object sender, EventArgs e)
        {
            openChildform(Library);
            hidesubmenu();
        }

        private void PlaylistManagment_Click(object sender, EventArgs e)
        {
            showSubMenu(panelplaylist);
        }
        //submenu de playlist
        private void button6_Click(object sender, EventArgs e)
        {
            openChildform(Playlists);
            hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Create playlist
            openChildform(Create);
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
            MainForm_ChildFormPanel.Controls.Add(childform);
            MainForm_ChildFormPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            //code..
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
            
            
            
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            showSubMenu(Searchpanel);
        }

        private void Serach_Song_button_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Search_Movie_button_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Search_Playlist_button_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e) 
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void Select_song_button_Click(object sender, EventArgs e)
        {
            string originalpath = Environment.CurrentDirectory;
            int striglen = originalpath.Length;
            string newpath = originalpath.Remove(striglen - 10, 10);
            string folderpath = Path.Combine(newpath, @"Songs\");
            try
            {
                int a = int.Parse(Numerocanciontext.Text);
                string final = Path.Combine(folderpath, @Songsdata[a].filename);
                axWindowsMediaPlayer1.URL = final;
            }
            catch
            {
                MessageBox.Show("Número no válido, ingrese nuevamente");
            }

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            //Songsdata.Add(ImportSong.sendSong);
            if (Songsdata.Count != 0)
            {
                int numero = 0;
                foreach (Song i in Songsdata)
                {
                    
                    int este = i.filename.Length;
                    string nombresd = i.filename.Remove(este - 4, 4);

                    richTextBox1.Text += numero+"   "+nombresd+"\n";
                    numero ++;
                }
            }

            //axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void panelreproduccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Youtubebtn_Click(object sender, EventArgs e)
        {
            openChildform(YouTube);
        }
    }
}
