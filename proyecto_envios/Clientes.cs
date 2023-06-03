using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_envios
{
    public partial class Clientes : Form
    {

        cls_negocios objenti = new cls_negocios();
        public Clientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ConsultaCliente();
        }

        public void ConsultaCliente()
        {

            dtcliente.DataSource = objenti.GetCli();
        }

        public void Limpia()
        {
            MessageBox.Show("Se han limpiado los espacios");
            txtdocumento.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtcodigopos.Clear();
        }

        public void consultas()
        {
            try
            {

                objenti.Documento_cliente = int.Parse(txtdocumento.Text.Trim());
                dtcliente.DataSource = objenti.Getusu();
            }
            catch
            {
                MessageBox.Show("Debe ingresar un cliente");
            }
        }

        public void Ingresa_cliente()
        {
            try
            {
                objenti.Nombre_cliente = txtnombre.Text;
            objenti.Documento_cliente = int.Parse(txtdocumento.Text.Trim());
            objenti.Telefono_cliente = txttelefono.Text;
            objenti.Correo_cliente = txtcorreo.Text;
            objenti.Codigo_postal_cliente = txtcodigopos.Text;

            objenti.ingresar_usuario();

            MessageBox.Show("El cliente a fue agregado exitosamente");
                ConsultaCliente();
            }
            catch
            {
                MessageBox.Show("Debe ingresar un cliente");
            }
        }

        public void Eliminar_cliente()
        {
            try
            {
                objenti.Documento_cliente = int.Parse(txtdocumento.Text.Trim());
            objenti.EliminarCliente();
            MessageBox.Show("El cliente a fue Eliminado exitosamente");
            Limpia();
            ConsultaCliente();
            }
            catch
            {
                MessageBox.Show("Debe ingresar un cliente");
            }
        }


        public void Actualiza_cliente()
        {
            try
            {
                objenti.Nombre_cliente = txtnombre.Text;
            objenti.Documento_cliente = int.Parse(txtdocumento.Text.Trim());
            objenti.Telefono_cliente = txttelefono.Text;
            objenti.Correo_cliente = txtcorreo.Text;
            objenti.Codigo_postal_cliente = txtcodigopos.Text;

            objenti.ActualizaCliente();
            ConsultaCliente();

            MessageBox.Show("El cliente " +txtnombre.Text+" fue actualizado exitosamente");
            }
            catch
            {
                MessageBox.Show("Debe ingresar un cliente");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu frm = new Menu();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultas();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingresa_cliente();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar_cliente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualiza_cliente();
        }

        private void dtcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dtcliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int documento = Convert.ToInt32(this.dtcliente.SelectedRows[0].Cells[0].Value);
                string nombre = this.dtcliente.SelectedRows[0].Cells[1].Value.ToString();
                string telefono = this.dtcliente.SelectedRows[0].Cells[2].Value.ToString();
                string correo = this.dtcliente.SelectedRows[0].Cells[3].Value.ToString();
                string codigo = this.dtcliente.SelectedRows[0].Cells[4].Value.ToString();

                txtnombre.Text = nombre;
                txtdocumento.Text = documento.ToString();
                txttelefono.Text = telefono;
                txtcorreo.Text = correo;
                txtcodigopos.Text = codigo;


            }
            catch
            {


            }

        }

        private void dtcliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int documento = Convert.ToInt32(this.dtcliente.SelectedRows[0].Cells[0].Value);
                string nombre = this.dtcliente.SelectedRows[0].Cells[1].Value.ToString();
                string telefono = this.dtcliente.SelectedRows[0].Cells[2].Value.ToString();
                string correo = this.dtcliente.SelectedRows[0].Cells[3].Value.ToString();
                string codigo = this.dtcliente.SelectedRows[0].Cells[4].Value.ToString();

                txtnombre.Text = nombre;
                txtdocumento.Text = documento.ToString();
                txttelefono.Text = telefono;
                txtcorreo.Text = correo;
                txtcodigopos.Text = codigo;


            }
            catch
            {


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConsultaCliente();
            Limpia();
        }
    }
}

