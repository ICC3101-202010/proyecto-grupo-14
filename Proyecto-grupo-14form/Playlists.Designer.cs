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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Songs_playlist_panel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Songs_playlist_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Movie_playlist_panel.SuspendLayout();
            this.Songs_playlist_panel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(204, 403);
            this.panel1.TabIndex = 0;
            // 
            // Movie_playlist_panel
            // 
            this.Movie_playlist_panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.Movie_playlist_panel.Controls.Add(this.listBox2);
            this.Movie_playlist_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Movie_playlist_panel.Location = new System.Drawing.Point(0, 282);
            this.Movie_playlist_panel.Name = "Movie_playlist_panel";
            this.Movie_playlist_panel.Size = new System.Drawing.Size(204, 192);
            this.Movie_playlist_panel.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 192);
            this.listBox2.TabIndex = 0;
            this.listBox2.Click += new System.EventHandler(this.myListbox_2Click);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
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
            this.Songs_playlist_panel.Controls.Add(this.listBox1);
            this.Songs_playlist_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Songs_playlist_panel.Location = new System.Drawing.Point(0, 45);
            this.Songs_playlist_panel.Name = "Songs_playlist_panel";
            this.Songs_playlist_panel.Size = new System.Drawing.Size(204, 192);
            this.Songs_playlist_panel.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 192);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.myListBox_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.RoyalBlue;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(204, -78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 481);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Private:";
            // 
            // Playlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(668, 403);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Playlists";
            this.Text = "Playlists";
            this.panel1.ResumeLayout(false);
            this.Movie_playlist_panel.ResumeLayout(false);
            this.Songs_playlist_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Songs_playlist_button;
        private System.Windows.Forms.Panel Movie_playlist_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Songs_playlist_panel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}