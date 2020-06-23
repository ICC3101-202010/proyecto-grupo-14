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
    
    public partial class Playlists : Form
    {
        List<Playlist_song> p1 = new List<Playlist_song>();
        List<Playlist_movie> p2 = new List<Playlist_movie>();
        public Playlists(Create_Playlist create)
        {
            InitializeComponent();
            CustomizeDesign();
            create.pasadom += new Create_Playlist.pasarm(ejecutar);
            create.pasados += new Create_Playlist.pasars(ejecutars);
        }
       
        public void ejecutars(Playlist_song sss)
        {
            string name = sss.Name;

            p1.Add(sss);
            listBox1.Items.Add(name);
        }
        public void ejecutar(Playlist_movie playlist_Movie)
        {
            string name = playlist_Movie.Name;
            p2.Add(playlist_Movie);
            listBox2.Items.Add(name);
            
        }
        private void addP_song(Playlist_song playlist)
        {

        }
        private void CustomizeDesign()
        {
            Songs_playlist_panel.Visible = false;
            Movie_playlist_panel.Visible = false;
        }
        private void hidesubmenu()
        {
            if (Songs_playlist_panel.Visible == true)
                Songs_playlist_panel.Visible = false;
            if (Movie_playlist_panel.Visible == true)
                Movie_playlist_panel.Visible = false;
            
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void MainForm_MediaButton_Click(object sender, EventArgs e)
        {
            showSubMenu(Songs_playlist_panel);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(Movie_playlist_panel);
        }
        private void myListBox_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label1.Text=listBox1.SelectedItem.ToString();
                foreach(Playlist_song i in p1)
                {
                    if (i.Name == listBox1.SelectedItem.ToString())
                    {
                        label3.Text = i.Duration.ToString();
                        label2.Text = i.Private.ToString();
                        foreach(Song j in i.Songs)
                        {
                            listView1.Items.Add(j.filename);
                        }
                    }
                }
            }
        }
        private void myListbox_2Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                label1.Text = listBox2.SelectedItem.ToString();
                foreach (Playlist_movie i in p2)
                {
                    if (i.Name == listBox2.SelectedItem.ToString())
                    {
                        label3.Text = i.Duration.ToString();
                        label2.Text = i.Private.ToString();
                        foreach (Movie j in i.Movies)
                        {
                            listView1.Items.Add(j.Filename);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
