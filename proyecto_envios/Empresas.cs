using negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyecto_envios
{
    public partial class Empresas : Form
    {
        cls_negocios objenti = new cls_negocios();
        public Empresas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            consultaemp();
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

                objenti.Documento_empresa = int.Parse(txtdocumento.Text.Trim());
                dtempresas.DataSource = objenti.GetEmp();
            }
            catch
            {
                MessageBox.Show("Debe incluir un numero de identificaion para buscar la empresa");
            }
        }

        public void Ingresa_empresa()
        {
            try
            {
                objenti.Nombre_empresa = txtnombre.Text;
                objenti.Documento_empresa = int.Parse(txtdocumento.Text.Trim());
                objenti.Telefono_empresa = txttelefono.Text;
                objenti.Correo_empresa = txtcorreo.Text;
                objenti.Codigo_postal_empresa = txtcodigopos.Text;
                objenti.ingresar_empresa();

                MessageBox.Show("La empresa " + txtnombre.Text + " fue agregado exitosamente");
                Limpia();
            }
            catch
            {
                MessageBox.Show("Esa empresa no puede ser agregada");

            }
        }
        public void Eliminar_empresa()
        {
            try
            {
                objenti.Documento_empresa = int.Parse(txtdocumento.Text.Trim());
                objenti.EliminarEmpresa();
                MessageBox.Show("La empresa " + txtnombre.Text + " fue eliminada exitosamente");
                Limpia();
                consultaemp();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una empresa");

            }
        }


    public void Actualiza_empresa()
        {
            try
            {
                objenti.Nombre_empresa = txtnombre.Text;
                objenti.Documento_empresa = int.Parse(txtdocumento.Text.Trim());
                objenti.Telefono_empresa = txttelefono.Text;
                objenti.Correo_empresa = txtcorreo.Text;
                objenti.Codigo_postal_empresa = txtcodigopos.Text;

                objenti.ActualizaEmpresa();

                MessageBox.Show("La empresa " + txtnombre.Text + " fue actualizada exitosamente");
                consultaemp();
            }
            catch
            {
                MessageBox.Show("Debe ingresar una empresa a modificar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu frm = new Menu();

            frm.Show();
        }

        public void consultaemp()
        {

            dtempresas.DataSource = objenti.GetEmpre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingresa_empresa();
            consultaemp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar_empresa();
            consultaemp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualiza_empresa();
        }

        private void dtempresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int documento = Convert.ToInt32(this.dtempresas.SelectedRows[0].Cells[0].Value);
                string nombre = this.dtempresas.SelectedRows[0].Cells[1].Value.ToString();
                string telefono = this.dtempresas.SelectedRows[0].Cells[2].Value.ToString();
                string correo = this.dtempresas.SelectedRows[0].Cells[3].Value.ToString();
                string codigo = this.dtempresas.SelectedRows[0].Cells[4].Value.ToString();

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

        private void button6_Click(object sender, EventArgs e)
        {
            consultaemp();
            Limpia();
        }
    }
}
