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
        public Playlists()
        {
            InitializeComponent();
            CustomizeDesign();
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
    }
}
