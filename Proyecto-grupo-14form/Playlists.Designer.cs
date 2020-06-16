namespace Proyecto_grupo_14form
{
    partial class Playlists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Movie_playlist_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Songs_playlist_panel = new System.Windows.Forms.Panel();
            this.Songs_playlist_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.Movie_playlist_panel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Songs_playlist_panel);
            this.panel1.Controls.Add(this.Songs_playlist_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 571);
            this.panel1.TabIndex = 0;
            // 
            // Movie_playlist_panel
            // 
            this.Movie_playlist_panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.Movie_playlist_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Movie_playlist_panel.Location = new System.Drawing.Point(0, 282);
            this.Movie_playlist_panel.Name = "Movie_playlist_panel";
            this.Movie_playlist_panel.Size = new System.Drawing.Size(204, 192);
            this.Movie_playlist_panel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 237);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(204, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Movie playlists";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Songs_playlist_panel
            // 
            this.Songs_playlist_panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.Songs_playlist_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Songs_playlist_panel.Location = new System.Drawing.Point(0, 45);
            this.Songs_playlist_panel.Name = "Songs_playlist_panel";
            this.Songs_playlist_panel.Size = new System.Drawing.Size(204, 192);
            this.Songs_playlist_panel.TabIndex = 9;
            // 
            // Songs_playlist_button
            // 
            this.Songs_playlist_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Songs_playlist_button.FlatAppearance.BorderSize = 0;
            this.Songs_playlist_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Songs_playlist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Songs_playlist_button.ForeColor = System.Drawing.Color.LightGray;
            this.Songs_playlist_button.Location = new System.Drawing.Point(0, 0);
            this.Songs_playlist_button.Name = "Songs_playlist_button";
            this.Songs_playlist_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Songs_playlist_button.Size = new System.Drawing.Size(204, 45);
            this.Songs_playlist_button.TabIndex = 6;
            this.Songs_playlist_button.Text = "Songs playlists";
            this.Songs_playlist_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Songs_playlist_button.UseVisualStyleBackColor = true;
            this.Songs_playlist_button.Click += new System.EventHandler(this.MainForm_MediaButton_Click);
            // 
            // Playlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(792, 571);
            this.Controls.Add(this.panel1);
            this.Name = "Playlists";
            this.Text = "Playlists";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Songs_playlist_button;
        private System.Windows.Forms.Panel Movie_playlist_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Songs_playlist_panel;
    }
}