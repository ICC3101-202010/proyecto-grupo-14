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
    public partial class YouTube : Form
    {
        public YouTube()
        {
            InitializeComponent();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void Youtube_YoutubeButton_Click(object sender, EventArgs e)
        {
            String str1 = YouTube_TextBox.Text;
            str1 = str1.Replace("=", "/");
            str1 = str1.Replace("watch?", "");
            axShockwaveFlash1.Movie = str1.Trim();
        }
    }
}
