namespace Proyecto_grupo_14form
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.Searchpanel = new System.Windows.Forms.Panel();
            this.Search_Playlist_button = new System.Windows.Forms.Button();
            this.Search_Movie_button = new System.Windows.Forms.Button();
            this.Serach_Song_button = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.panelprofile = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.panelplaylist = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PlaylistManagment = new System.Windows.Forms.Button();
            this.panelmedia = new System.Windows.Forms.Panel();
            this.Mediasubmenu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MainForm_MediaButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelreproduccion = new System.Windows.Forms.Panel();
            this.Next_button = new System.Windows.Forms.Button();
            this.MainForm_SelectSongButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.open_button = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.MainForm_ChildFormPanel = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Numerocanciontext = new System.Windows.Forms.TextBox();
            this.panelSideMenu.SuspendLayout();
            this.Searchpanel.SuspendLayout();
            this.panelprofile.SuspendLayout();
            this.panelplaylist.SuspendLayout();
            this.panelmedia.SuspendLayout();
            this.panelreproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.MainForm_ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.Searchpanel);
            this.panelSideMenu.Controls.Add(this.Search);
            this.panelSideMenu.Controls.Add(this.panelprofile);
            this.panelSideMenu.Controls.Add(this.Profile);
            this.panelSideMenu.Controls.Add(this.panelplaylist);
            this.panelSideMenu.Controls.Add(this.PlaylistManagment);
            this.panelSideMenu.Controls.Add(this.panelmedia);
            this.panelSideMenu.Controls.Add(this.MainForm_MediaButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 729);
            this.panelSideMenu.TabIndex = 0;
            // 
            // Searchpanel
            // 
            this.Searchpanel.BackColor = System.Drawing.Color.Black;
            this.Searchpanel.Controls.Add(this.Search_Playlist_button);
            this.Searchpanel.Controls.Add(this.Search_Movie_button);
            this.Searchpanel.Controls.Add(this.Serach_Song_button);
            this.Searchpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Searchpanel.Location = new System.Drawing.Point(0, 628);
            this.Searchpanel.Name = "Searchpanel";
            this.Searchpanel.Size = new System.Drawing.Size(183, 192);
            this.Searchpanel.TabIndex = 8;
            // 
            // Search_Playlist_button
            // 
            this.Search_Playlist_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Search_Playlist_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_Playlist_button.FlatAppearance.BorderSize = 0;
            this.Search_Playlist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Search_Playlist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Playlist_button.Location = new System.Drawing.Point(0, 80);
            this.Search_Playlist_button.Name = "Search_Playlist_button";
            this.Search_Playlist_button.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Search_Playlist_button.Size = new System.Drawing.Size(183, 40);
            this.Search_Playlist_button.TabIndex = 2;
            this.Search_Playlist_button.Text = "Playslit";
            this.Search_Playlist_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_Playlist_button.UseVisualStyleBackColor = false;
            this.Search_Playlist_button.Click += new System.EventHandler(this.Search_Playlist_button_Click);
            // 
            // Search_Movie_button
            // 
            this.Search_Movie_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Search_Movie_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_Movie_button.FlatAppearance.BorderSize = 0;
            this.Search_Movie_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Search_Movie_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Movie_button.Location = new System.Drawing.Point(0, 40);
            this.Search_Movie_button.Name = "Search_Movie_button";
            this.Search_Movie_button.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Search_Movie_button.Size = new System.Drawing.Size(183, 40);
            this.Search_Movie_button.TabIndex = 1;
            this.Search_Movie_button.Text = "Movie";
            this.Search_Movie_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_Movie_button.UseVisualStyleBackColor = false;
            this.Search_Movie_button.Click += new System.EventHandler(this.Search_Movie_button_Click);
            // 
            // Serach_Song_button
            // 
            this.Serach_Song_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.Serach_Song_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Serach_Song_button.FlatAppearance.BorderSize = 0;
            this.Serach_Song_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Serach_Song_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serach_Song_button.Location = new System.Drawing.Point(0, 0);
            this.Serach_Song_button.Name = "Serach_Song_button";
            this.Serach_Song_button.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Serach_Song_button.Size = new System.Drawing.Size(183, 40);
            this.Serach_Song_button.TabIndex = 0;
            this.Serach_Song_button.Text = "Song";
            this.Serach_Song_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Serach_Song_button.UseVisualStyleBackColor = false;
            this.Serach_Song_button.Click += new System.EventHandler(this.Serach_Song_button_Click);
            // 
            // Search
            // 
            this.Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.LightGray;
            this.Search.Location = new System.Drawing.Point(0, 579);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Search.Size = new System.Drawing.Size(183, 49);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panelprofile
            // 
            this.panelprofile.BackColor = System.Drawing.Color.Maroon;
            this.panelprofile.Controls.Add(this.button8);
            this.panelprofile.Controls.Add(this.button9);
            this.panelprofile.Controls.Add(this.button10);
            this.panelprofile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelprofile.Location = new System.Drawing.Point(0, 458);
            this.panelprofile.Name = "panelprofile";
            this.panelprofile.Size = new System.Drawing.Size(183, 121);
            this.panelprofile.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 84);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(183, 41);
            this.button8.TabIndex = 2;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 44);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(183, 40);
            this.button9.TabIndex = 1;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(183, 44);
            this.button10.TabIndex = 0;
            this.button10.Text = "button10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Profile
            // 
            this.Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.ForeColor = System.Drawing.Color.LightGray;
            this.Profile.Location = new System.Drawing.Point(0, 409);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Profile.Size = new System.Drawing.Size(183, 49);
            this.Profile.TabIndex = 5;
            this.Profile.Text = "Profile";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // panelplaylist
            // 
            this.panelplaylist.BackColor = System.Drawing.Color.Maroon;
            this.panelplaylist.Controls.Add(this.button4);
            this.panelplaylist.Controls.Add(this.button5);
            this.panelplaylist.Controls.Add(this.button6);
            this.panelplaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelplaylist.Location = new System.Drawing.Point(0, 285);
            this.panelplaylist.Name = "panelplaylist";
            this.panelplaylist.Size = new System.Drawing.Size(183, 124);
            this.panelplaylist.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(183, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete Playlist";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 40);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(183, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "Create Playlist";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(183, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "My Playlists";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PlaylistManagment
            // 
            this.PlaylistManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistManagment.FlatAppearance.BorderSize = 0;
            this.PlaylistManagment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PlaylistManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaylistManagment.ForeColor = System.Drawing.Color.LightGray;
            this.PlaylistManagment.Location = new System.Drawing.Point(0, 240);
            this.PlaylistManagment.Name = "PlaylistManagment";
            this.PlaylistManagment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PlaylistManagment.Size = new System.Drawing.Size(183, 45);
            this.PlaylistManagment.TabIndex = 3;
            this.PlaylistManagment.Text = "Playlist Managment";
            this.PlaylistManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaylistManagment.UseVisualStyleBackColor = true;
            this.PlaylistManagment.Click += new System.EventHandler(this.PlaylistManagment_Click);
            // 
            // panelmedia
            // 
            this.panelmedia.BackColor = System.Drawing.Color.Maroon;
            this.panelmedia.Controls.Add(this.Mediasubmenu);
            this.panelmedia.Controls.Add(this.button3);
            this.panelmedia.Controls.Add(this.button2);
            this.panelmedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmedia.Location = new System.Drawing.Point(0, 124);
            this.panelmedia.Name = "panelmedia";
            this.panelmedia.Size = new System.Drawing.Size(183, 116);
            this.panelmedia.TabIndex = 2;
            // 
            // Mediasubmenu
            // 
            this.Mediasubmenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.Mediasubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mediasubmenu.FlatAppearance.BorderSize = 0;
            this.Mediasubmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Mediasubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mediasubmenu.Location = new System.Drawing.Point(0, 80);
            this.Mediasubmenu.Name = "Mediasubmenu";
            this.Mediasubmenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Mediasubmenu.Size = new System.Drawing.Size(183, 40);
            this.Mediasubmenu.TabIndex = 2;
            this.Mediasubmenu.Text = "Library";
            this.Mediasubmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mediasubmenu.UseVisualStyleBackColor = false;
            this.Mediasubmenu.Click += new System.EventHandler(this.Mediasubmenu_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(183, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Import Movie";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Import Song";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm_MediaButton
            // 
            this.MainForm_MediaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainForm_MediaButton.FlatAppearance.BorderSize = 0;
            this.MainForm_MediaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainForm_MediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainForm_MediaButton.ForeColor = System.Drawing.Color.LightGray;
            this.MainForm_MediaButton.Location = new System.Drawing.Point(0, 79);
            this.MainForm_MediaButton.Name = "MainForm_MediaButton";
            this.MainForm_MediaButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MainForm_MediaButton.Size = new System.Drawing.Size(183, 45);
            this.MainForm_MediaButton.TabIndex = 1;
            this.MainForm_MediaButton.Text = "Media";
            this.MainForm_MediaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainForm_MediaButton.UseVisualStyleBackColor = true;
            this.MainForm_MediaButton.Click += new System.EventHandler(this.Media_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 79);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelreproduccion
            // 
            this.panelreproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelreproduccion.Controls.Add(this.Numerocanciontext);
            this.panelreproduccion.Controls.Add(this.Next_button);
            this.panelreproduccion.Controls.Add(this.MainForm_SelectSongButton);
            this.panelreproduccion.Controls.Add(this.trackBar1);
            this.panelreproduccion.Controls.Add(this.richTextBox1);
            this.panelreproduccion.Controls.Add(this.open_button);
            this.panelreproduccion.Controls.Add(this.btnPlay1);
            this.panelreproduccion.Controls.Add(this.Pause_button);
            this.panelreproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelreproduccion.Location = new System.Drawing.Point(200, 610);
            this.panelreproduccion.Name = "panelreproduccion";
            this.panelreproduccion.Size = new System.Drawing.Size(808, 119);
            this.panelreproduccion.TabIndex = 1;
            this.panelreproduccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelreproduccion_Paint);
            // 
            // Next_button
            // 
            this.Next_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Next_button.Location = new System.Drawing.Point(325, 11);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(69, 25);
            this.Next_button.TabIndex = 7;
            this.Next_button.Text = "Show";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // MainForm_SelectSongButton
            // 
            this.MainForm_SelectSongButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MainForm_SelectSongButton.Location = new System.Drawing.Point(417, 11);
            this.MainForm_SelectSongButton.Name = "MainForm_SelectSongButton";
            this.MainForm_SelectSongButton.Size = new System.Drawing.Size(100, 25);
            this.MainForm_SelectSongButton.TabIndex = 6;
            this.MainForm_SelectSongButton.Text = "Select song";
            this.MainForm_SelectSongButton.UseVisualStyleBackColor = true;
            this.MainForm_SelectSongButton.Click += new System.EventHandler(this.Select_song_button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(594, 62);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(202, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // open_button
            // 
            this.open_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.open_button.Location = new System.Drawing.Point(706, 21);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(81, 26);
            this.open_button.TabIndex = 3;
            this.open_button.Text = "Display";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay1.Location = new System.Drawing.Point(417, 81);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(69, 26);
            this.btnPlay1.TabIndex = 2;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pause_button.Location = new System.Drawing.Point(492, 81);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(69, 26);
            this.Pause_button.TabIndex = 1;
            this.Pause_button.Text = "Pause";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm_ChildFormPanel
            // 
            this.MainForm_ChildFormPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.MainForm_ChildFormPanel.Controls.Add(this.axWindowsMediaPlayer1);
            this.MainForm_ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_ChildFormPanel.Location = new System.Drawing.Point(200, 0);
            this.MainForm_ChildFormPanel.Name = "MainForm_ChildFormPanel";
            this.MainForm_ChildFormPanel.Size = new System.Drawing.Size(808, 610);
            this.MainForm_ChildFormPanel.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(808, 610);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Numerocanciontext
            // 
            this.Numerocanciontext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Numerocanciontext.Location = new System.Drawing.Point(531, 13);
            this.Numerocanciontext.Name = "Numerocanciontext";
            this.Numerocanciontext.Size = new System.Drawing.Size(30, 23);
            this.Numerocanciontext.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.MainForm_ChildFormPanel);
            this.Controls.Add(this.panelreproduccion);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "MainForm";
            this.Text = "Blue Void";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.Searchpanel.ResumeLayout(false);
            this.panelprofile.ResumeLayout(false);
            this.panelplaylist.ResumeLayout(false);
            this.panelmedia.ResumeLayout(false);
            this.panelreproduccion.ResumeLayout(false);
            this.panelreproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.MainForm_ChildFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelprofile;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Panel panelplaylist;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button PlaylistManagment;
        private System.Windows.Forms.Panel panelmedia;
        private System.Windows.Forms.Button Mediasubmenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MainForm_MediaButton;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelreproduccion;
        private System.Windows.Forms.Panel MainForm_ChildFormPanel;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Panel Searchpanel;
        private System.Windows.Forms.Button Search_Playlist_button;
        private System.Windows.Forms.Button Search_Movie_button;
        private System.Windows.Forms.Button Serach_Song_button;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button MainForm_SelectSongButton;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.TextBox Numerocanciontext;
    }
}

