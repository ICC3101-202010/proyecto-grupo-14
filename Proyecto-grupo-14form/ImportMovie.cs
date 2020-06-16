using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Media;


namespace Proyecto_grupo_14form
{
    public partial class ImportMovie : Form
    {
        public ImportMovie()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void ImportMovie_Load(object sender, EventArgs e)
        {

        }

        private void ImportMovie_AddMovieButton_Click(object sender, EventArgs e)
        {
            string sourcepath = ImportMovie_OFD_FilePathTextBox.Text;
            string filename = ImportMovie_OFD_FileNameTextBox.Text;
            string originalpath = Environment.CurrentDirectory;
            int striglen = originalpath.Length;

            string newpath = originalpath.Remove(striglen - 10, 10);
            string folderpath = Path.Combine(newpath, @"Movies\");
            string targetpath = Path.Combine(folderpath, filename);
            File.Copy(sourcepath, targetpath, true);
            string Quality = "High";
            string type = new FileInfo(targetpath).Extension;

            long length = 0;

            long size = new FileInfo(targetpath).Length;
            string Description = "";
            if (ImportMovie_DescriptionTextBox.Text != null)
            {
                Description = ImportMovie_DescriptionTextBox.Text;
            }
            int rating = 0;
            int Views = 0;
            DateTime added = DateTime.Now;
            string Studio = "";
            if (ImportMovie_StudioTextBox.Text != null)
            {
                Studio = ImportMovie_StudioTextBox.Text;
            }
            int likes = 0;
            string director = "";
            if (ImportMovie_DirectorTextBox.Text != null)
            {
                director = ImportMovie_DirectorTextBox.Text;
            }


            string category = "";
            if (ImportMovie_CategoryTextBox.Text != null)
            {
                category = ImportMovie_CategoryTextBox.Text;
            }

            int release = 0;
            if (ImportMovie_ReleaseTextBox.Text != null)
            {
                release = Convert.ToInt32(ImportMovie_ReleaseTextBox.Text);
            }
            string genre = "";
            if (ImportMovie_GenreTextBox.Text != null)
            {
                genre = ImportMovie_GenreTextBox.Text;
            }

            Movie m = new Movie(targetpath, filename, length, release, Quality, genre, type, size, Description, rating, Views, added, Studio, likes, category, director);
            MainForm.Moviesdata.Add(m);
            ImportMovie_OFD_FileNameTextBox.Clear();
            ImportMovie_OFD_FilePathTextBox.Clear();
            ImportMovie_CategoryTextBox.Clear();
            ImportMovie_DirectorTextBox.Clear();
            ImportMovie_GenreTextBox.Clear();
            ImportMovie_ReleaseTextBox.Clear();
            ImportMovie_StudioTextBox.Clear();
            ImportMovie_DescriptionTextBox.Clear();



        }

        private void ImportMovie_OpenFileButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImportMovie_OFD_FilePathTextBox.Text = ofd.FileName;
                ImportMovie_OFD_FileNameTextBox.Text = ofd.SafeFileName;
            }
        }
    }
}
