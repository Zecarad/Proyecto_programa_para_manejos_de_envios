using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using negocios;

namespace proyecto_envios
{
    public partial class AgregarUsuario : Form
    {

        cls_negocios objenti = new cls_negocios();
        public AgregarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login frm = new Login();

            frm.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu frm = new Menu();

            frm.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            IngresaUsuario();
        }
        public void IngresaUsuario()
        {
            try
            {
                objenti.Usuario = usuario.Text;
                objenti.Contraseña = contraseña.Text;
                objenti.IngresaUsu();

                MessageBox.Show("El usuario se generó exitosamente");
                usuario.Clear();
                contraseña.Clear();
            }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos con la inforamcion");
            }
        }
    }
}
