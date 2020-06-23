using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto_grupo_14form
{
    public partial class Register_and_login : Form
    {
        public Register_and_login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection mainconn = new SqlConnection(@"Data Source=STL-4110;Initial Catalog=Usuarios;Integrated Security=True");
            SqlCommand query = new SqlCommand("select * from Usuarios where Usuario=@Usuario and Contraseña =@Contraseña", mainconn);
            query.Parameters.AddWithValue("@Usuario", textBox1.Text);
            query.Parameters.AddWithValue("@Contraseña", textBox2.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(query);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            mainconn.Open();
            int i = query.ExecuteNonQuery();
            mainconn.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido usuario");
                MainForm aplicacion = new MainForm();
                aplicacion.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                string Sex = "";
                int Cuenta = 0;
                if (Male.Checked == true)
                { Sex = "H"; }
                if (Female.Checked == true)
                { Sex = "M"; }
                if (Otro.Checked == true)
                { Sex = "Otro"; }
                if (Gratuita.Checked == true)
                { Cuenta = 0; }
                if (Pagada.Checked == true)
                { Cuenta = 1; }
                if (Premium.Checked == true)
                { Cuenta = 2; }
                SqlConnection conecta = new SqlConnection(@"Data Source=STL-4110;Initial Catalog=Practice;Integrated Security=True");
                string ingresar = "insert into Usuarios(Email,Usuario,Contraseña,Sexo,Cuenta) values('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + Sex + "','" + Cuenta + "')";
                conecta.Open();
                SqlCommand com = new SqlCommand(ingresar, conecta);
                com.ExecuteNonQuery();
            }
            else
            { MessageBox.Show("Contraseñas no coinciden"); }
        }

    } }   
