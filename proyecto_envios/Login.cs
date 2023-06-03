using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace proyecto_envios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PE412M7\\SQLEXPRESS;Initial Catalog=PROYECTO_PROG3;Integrated Security=True");
        public void ingreso()
        {
            conn.Open();
            string consulta = "SELECT * from USUARIOS WHERE usuario='"+usuario.Text+"' and contraseña= '"+contraseña.Text+ "'";
            SqlCommand com = new SqlCommand(consulta, conn);
            SqlDataReader lectura;
            lectura = com.ExecuteReader();


            if (lectura.HasRows == true)
            {
                MessageBox.Show("El usuario es correcto, bienvenido");
                this.Hide();

                Menu frm = new Menu();

                frm.Show();
            }
            else
            {
                MessageBox.Show("Informacion no corresponde con un usuario autorizado");
            }
            conn.Close();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ingreso();

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
