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
            this.ImportSong_ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.ImportSong_GenreTextBox = new System.Windows.Forms.TextBox();
            this.ImportSong_StudioTextBox = new System.Windows.Forms.TextBox();
            this.ImportSong_ArtistTextBox = new System.Windows.Forms.TextBox();
            this.ImportSong_AlbumTextBox = new System.Windows.Forms.TextBox();
            this.ImportSong_LyricsTextBox = new System.Windows.Forms.RichTextBox();
            this.ImportSong_DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ImportSong_ReleasedLabel = new System.Windows.Forms.Label();
            this.ImportSong_GenreLabel = new System.Windows.Forms.Label();
            this.ImportSong_StudioLabel = new System.Windows.Forms.Label();
            this.ImportSong_ArtistLabel = new System.Windows.Forms.Label();
            this.ImportSong_AlbumLabel = new System.Windows.Forms.Label();
            this.Lyrics_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImportSong_MainLabel
            // 
            this.ImportSong_MainLabel.AutoSize = true;
            this.ImportSong_MainLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ImportSong_MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImportSong_MainLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_MainLabel.Location = new System.Drawing.Point(49, 22);
            this.ImportSong_MainLabel.Name = "ImportSong_MainLabel";
            this.ImportSong_MainLabel.Size = new System.Drawing.Size(95, 17);
            this.ImportSong_MainLabel.TabIndex = 0;
            this.ImportSong_MainLabel.Text = "Import Song";
            // 
            // ImportSong_ReleaseTextBox
            // 
            this.ImportSong_ReleaseTextBox.Location = new System.Drawing.Point(52, 65);
            this.ImportSong_ReleaseTextBox.Name = "ImportSong_ReleaseTextBox";
            this.ImportSong_ReleaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportSong_ReleaseTextBox.TabIndex = 1;
            this.ImportSong_ReleaseTextBox.TextChanged += new System.EventHandler(this.textboxreleased_TextChanged);
            // 
            // ImportSong_GenreTextBox
            // 
            this.ImportSong_GenreTextBox.Location = new System.Drawing.Point(52, 107);
            this.ImportSong_GenreTextBox.Name = "ImportSong_GenreTextBox";
            this.ImportSong_GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportSong_GenreTextBox.TabIndex = 2;
            // 
            // ImportSong_StudioTextBox
            // 
            this.ImportSong_StudioTextBox.Location = new System.Drawing.Point(52, 150);
            this.ImportSong_StudioTextBox.Name = "ImportSong_StudioTextBox";
            this.ImportSong_StudioTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportSong_StudioTextBox.TabIndex = 3;
            // 
            // ImportSong_ArtistTextBox
            // 
            this.ImportSong_ArtistTextBox.Location = new System.Drawing.Point(52, 198);
            this.ImportSong_ArtistTextBox.Name = "ImportSong_ArtistTextBox";
            this.ImportSong_ArtistTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportSong_ArtistTextBox.TabIndex = 5;
            // 
            // ImportSong_AlbumTextBox
            // 
            this.ImportSong_AlbumTextBox.Location = new System.Drawing.Point(54, 248);
            this.ImportSong_AlbumTextBox.Name = "ImportSong_AlbumTextBox";
            this.ImportSong_AlbumTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportSong_AlbumTextBox.TabIndex = 6;
            // 
            // ImportSong_LyricsTextBox
            // 
            this.ImportSong_LyricsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImportSong_LyricsTextBox.Location = new System.Drawing.Point(52, 334);
            this.ImportSong_LyricsTextBox.Name = "ImportSong_LyricsTextBox";
            this.ImportSong_LyricsTextBox.Size = new System.Drawing.Size(189, 96);
            this.ImportSong_LyricsTextBox.TabIndex = 7;
            this.ImportSong_LyricsTextBox.Text = "";
            this.ImportSong_LyricsTextBox.TextChanged += new System.EventHandler(this.Lyrics_TextChanged);
            // 
            // ImportSong_DescriptionTextBox
            // 
            this.ImportSong_DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportSong_DescriptionTextBox.Location = new System.Drawing.Point(357, 334);
            this.ImportSong_DescriptionTextBox.Name = "ImportSong_DescriptionTextBox";
            this.ImportSong_DescriptionTextBox.Size = new System.Drawing.Size(189, 96);
            this.ImportSong_DescriptionTextBox.TabIndex = 8;
            this.ImportSong_DescriptionTextBox.Text = "";
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
            // ImportSong_StudioLabel
            // 
            this.ImportSong_StudioLabel.AutoSize = true;
            this.ImportSong_StudioLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_StudioLabel.Location = new System.Drawing.Point(49, 134);
            this.ImportSong_StudioLabel.Name = "ImportSong_StudioLabel";
            this.ImportSong_StudioLabel.Size = new System.Drawing.Size(40, 13);
            this.ImportSong_StudioLabel.TabIndex = 15;
            this.ImportSong_StudioLabel.Text = "Studio:";
            // 
            // ImportSong_ArtistLabel
            // 
            this.ImportSong_ArtistLabel.AutoSize = true;
            this.ImportSong_ArtistLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_ArtistLabel.Location = new System.Drawing.Point(50, 182);
            this.ImportSong_ArtistLabel.Name = "ImportSong_ArtistLabel";
            this.ImportSong_ArtistLabel.Size = new System.Drawing.Size(33, 13);
            this.ImportSong_ArtistLabel.TabIndex = 16;
            this.ImportSong_ArtistLabel.Text = "Artist:";
            // 
            // ImportSong_AlbumLabel
            // 
            this.ImportSong_AlbumLabel.AutoSize = true;
            this.ImportSong_AlbumLabel.ForeColor = System.Drawing.Color.White;
            this.ImportSong_AlbumLabel.Location = new System.Drawing.Point(51, 232);
            this.ImportSong_AlbumLabel.Name = "ImportSong_AlbumLabel";
            this.ImportSong_AlbumLabel.Size = new System.Drawing.Size(39, 13);
            this.ImportSong_AlbumLabel.TabIndex = 17;
            this.ImportSong_AlbumLabel.Text = "Album:";
            // 
            // Lyrics_label
            // 
            this.Lyrics_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lyrics_label.AutoSize = true;
            this.Lyrics_label.ForeColor = System.Drawing.Color.White;
            this.Lyrics_label.Location = new System.Drawing.Point(51, 318);
            this.Lyrics_label.Name = "Lyrics_label";
            this.Lyrics_label.Size = new System.Drawing.Size(37, 13);
            this.Lyrics_label.TabIndex = 18;
            this.Lyrics_label.Text = "Lyrics:";
            // 
            // Description_label
            // 
            this.Description_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Description_label.AutoSize = true;
            this.Description_label.ForeColor = System.Drawing.Color.White;
            this.Description_label.Location = new System.Drawing.Point(354, 318);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(63, 13);
            this.Description_label.TabIndex = 19;
            this.Description_label.Text = "Description:";
            // 
            // ImportSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(684, 442);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Lyrics_label);
            this.Controls.Add(this.ImportSong_AlbumLabel);
            this.Controls.Add(this.ImportSong_ArtistLabel);
            this.Controls.Add(this.ImportSong_StudioLabel);
            this.Controls.Add(this.ImportSong_GenreLabel);
            this.Controls.Add(this.ImportSong_ReleasedLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImportSong_DescriptionTextBox);
            this.Controls.Add(this.ImportSong_LyricsTextBox);
            this.Controls.Add(this.ImportSong_AlbumTextBox);
            this.Controls.Add(this.ImportSong_ArtistTextBox);
            this.Controls.Add(this.ImportSong_StudioTextBox);
            this.Controls.Add(this.ImportSong_GenreTextBox);
            this.Controls.Add(this.ImportSong_ReleaseTextBox);
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
        private System.Windows.Forms.TextBox ImportSong_ReleaseTextBox;
        private System.Windows.Forms.TextBox ImportSong_GenreTextBox;
        private System.Windows.Forms.TextBox ImportSong_StudioTextBox;
        private System.Windows.Forms.TextBox ImportSong_ArtistTextBox;
        private System.Windows.Forms.TextBox ImportSong_AlbumTextBox;
        private System.Windows.Forms.RichTextBox ImportSong_LyricsTextBox;
        private System.Windows.Forms.RichTextBox ImportSong_DescriptionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ImportSong_ReleasedLabel;
        private System.Windows.Forms.Label ImportSong_GenreLabel;
        private System.Windows.Forms.Label ImportSong_StudioLabel;
        private System.Windows.Forms.Label ImportSong_ArtistLabel;
        private System.Windows.Forms.Label ImportSong_AlbumLabel;
        private System.Windows.Forms.Label Lyrics_label;
        private System.Windows.Forms.Label Description_label;
    }
}