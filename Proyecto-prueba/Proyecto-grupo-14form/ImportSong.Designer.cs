namespace Proyecto_grupo_14form
{
    partial class ImportSong
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
            this.ImportSong_MainLabel = new System.Windows.Forms.Label();
            this.textboxreleased = new System.Windows.Forms.TextBox();
            this.textboxgenre = new System.Windows.Forms.TextBox();
            this.textboxstudio = new System.Windows.Forms.TextBox();
            this.studio = new System.Windows.Forms.TextBox();
            this.artist = new System.Windows.Forms.TextBox();
            this.album = new System.Windows.Forms.TextBox();
            this.richtextboxLyrics = new System.Windows.Forms.RichTextBox();
            this.richtextboxdescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ImportSong_ReleasedLabel = new System.Windows.Forms.Label();
            this.ImportSong_GenreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImportSong_MainLabel
            // 
            this.ImportSong_MainLabel.AutoSize = true;
            this.ImportSong_MainLabel.BackColor = System.Drawing.Color.MediumBlue;
            this.ImportSong_MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImportSong_MainLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_MainLabel.Location = new System.Drawing.Point(49, 22);
            this.ImportSong_MainLabel.Name = "ImportSong_MainLabel";
            this.ImportSong_MainLabel.Size = new System.Drawing.Size(95, 17);
            this.ImportSong_MainLabel.TabIndex = 0;
            this.ImportSong_MainLabel.Text = "Import Song";
            // 
            // textboxreleased
            // 
            this.textboxreleased.Location = new System.Drawing.Point(52, 65);
            this.textboxreleased.Name = "textboxreleased";
            this.textboxreleased.Size = new System.Drawing.Size(100, 20);
            this.textboxreleased.TabIndex = 1;
            this.textboxreleased.TextChanged += new System.EventHandler(this.textboxreleased_TextChanged);
            // 
            // textboxgenre
            // 
            this.textboxgenre.Location = new System.Drawing.Point(52, 107);
            this.textboxgenre.Name = "textboxgenre";
            this.textboxgenre.Size = new System.Drawing.Size(100, 20);
            this.textboxgenre.TabIndex = 2;
            // 
            // textboxstudio
            // 
            this.textboxstudio.Location = new System.Drawing.Point(52, 150);
            this.textboxstudio.Name = "textboxstudio";
            this.textboxstudio.Size = new System.Drawing.Size(100, 20);
            this.textboxstudio.TabIndex = 3;
            // 
            // studio
            // 
            this.studio.Location = new System.Drawing.Point(52, 190);
            this.studio.Name = "studio";
            this.studio.Size = new System.Drawing.Size(100, 20);
            this.studio.TabIndex = 4;
            // 
            // artist
            // 
            this.artist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artist.Location = new System.Drawing.Point(52, 227);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(100, 20);
            this.artist.TabIndex = 5;
            // 
            // album
            // 
            this.album.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.album.Location = new System.Drawing.Point(52, 270);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(100, 20);
            this.album.TabIndex = 6;
            // 
            // richtextboxLyrics
            // 
            this.richtextboxLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richtextboxLyrics.Location = new System.Drawing.Point(52, 334);
            this.richtextboxLyrics.Name = "richtextboxLyrics";
            this.richtextboxLyrics.Size = new System.Drawing.Size(189, 96);
            this.richtextboxLyrics.TabIndex = 7;
            this.richtextboxLyrics.Text = "";
            this.richtextboxLyrics.TextChanged += new System.EventHandler(this.Lyrics_TextChanged);
            // 
            // richtextboxdescription
            // 
            this.richtextboxdescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richtextboxdescription.Location = new System.Drawing.Point(285, 334);
            this.richtextboxdescription.Name = "richtextboxdescription";
            this.richtextboxdescription.Size = new System.Drawing.Size(189, 96);
            this.richtextboxdescription.TabIndex = 8;
            this.richtextboxdescription.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(586, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Song";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(357, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(561, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Open file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(357, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 12;
            // 
            // ImportSong_ReleasedLabel
            // 
            this.ImportSong_ReleasedLabel.AutoSize = true;
            this.ImportSong_ReleasedLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_ReleasedLabel.Location = new System.Drawing.Point(50, 50);
            this.ImportSong_ReleasedLabel.Name = "ImportSong_ReleasedLabel";
            this.ImportSong_ReleasedLabel.Size = new System.Drawing.Size(55, 13);
            this.ImportSong_ReleasedLabel.TabIndex = 13;
            this.ImportSong_ReleasedLabel.Text = "Released:";
            // 
            // ImportSong_GenreLabel
            // 
            this.ImportSong_GenreLabel.AutoSize = true;
            this.ImportSong_GenreLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_GenreLabel.Location = new System.Drawing.Point(50, 91);
            this.ImportSong_GenreLabel.Name = "ImportSong_GenreLabel";
            this.ImportSong_GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.ImportSong_GenreLabel.TabIndex = 14;
            this.ImportSong_GenreLabel.Text = "Genre:";
            // 
            // ImportSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(684, 442);
            this.Controls.Add(this.ImportSong_GenreLabel);
            this.Controls.Add(this.ImportSong_ReleasedLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richtextboxdescription);
            this.Controls.Add(this.richtextboxLyrics);
            this.Controls.Add(this.album);
            this.Controls.Add(this.artist);
            this.Controls.Add(this.studio);
            this.Controls.Add(this.textboxstudio);
            this.Controls.Add(this.textboxgenre);
            this.Controls.Add(this.textboxreleased);
            this.Controls.Add(this.ImportSong_MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportSong";
            this.Text = "ImportSong";
            this.Load += new System.EventHandler(this.ImportSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImportSong_MainLabel;
        private System.Windows.Forms.TextBox textboxreleased;
        private System.Windows.Forms.TextBox textboxgenre;
        private System.Windows.Forms.TextBox textboxstudio;
        private System.Windows.Forms.TextBox studio;
        private System.Windows.Forms.TextBox artist;
        private System.Windows.Forms.TextBox album;
        private System.Windows.Forms.RichTextBox richtextboxLyrics;
        private System.Windows.Forms.RichTextBox richtextboxdescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ImportSong_ReleasedLabel;
        private System.Windows.Forms.Label ImportSong_GenreLabel;
    }
}