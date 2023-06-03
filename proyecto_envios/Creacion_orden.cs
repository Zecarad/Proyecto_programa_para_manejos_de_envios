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

namespace proyecto_envios
{
    public partial class Creacion_orden : Form
    {
        cls_negocios objenti = new cls_negocios();

        public Creacion_orden()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            consultaord();
 
        }
        public void consultas()
        {
            try
            {

                var datos = objenti.GetUsu(int.Parse(txtdocumento.Text.Trim()));
                txtnombre.Text = datos.Item2;
                txttelefono.Text = datos.Item3;
                txtcorreo.Text = datos.Item4;

            }
            catch
            {

            }
        }

        public void consultaorden()
        {
            try
            {
                objenti.Documento_cliente = int.Parse(txtdocumento.Text.Trim());
            dtdatos.DataSource = objenti.Getorders();
            }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos con la inforamcion");
            }
        }

        public void empresa()
        {

            var datos = objenti.GetEmpresa(int.Parse(txtdocempresa.Text.Trim()));
            textBox1.Text = datos.Item2;

        }

        public void IngresaOrden()
        {
            try
            {


                objenti.Documento_cliente = int.Parse(txtdocumento.Text);
                objenti.Nombre_cliente = txtnombre.Text;
                objenti.Documento_empresa = int.Parse(txtdocempresa.Text);
                objenti.Nombre_empresa = textBox1.Text;
                objenti.Direccion = txtdireccion.Text;
                objenti.Monto = double.Parse(txtmonto.Text);


                objenti.ingresar_ordenes();

                MessageBox.Show("La orden se generó exitosamente");
                consultaord();
            }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos con la inforamcion");
            }
        }

        public void Actualiza_orden()
        {
            try
            {
                objenti.Documento_cliente = int.Parse(txtdocumento.Text);
            objenti.Nombre_cliente = txtnombre.Text;
            objenti.Documento_empresa = int.Parse(txtdocempresa.Text);
            objenti.Nombre_empresa = textBox1.Text;
            objenti.Direccion = txtdireccion.Text;
            objenti.Monto = double.Parse(txtmonto.Text);

            objenti.ActOrden();

            MessageBox.Show("El cliente " + txtnombre.Text + " fue actualizado exitosamente");
            consultaord();
            }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos con la inforamcion");
            }
        }

        public void consultaord()
        {

            dtdatos.DataSource = objenti.GetOrd();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtmonto.Text = "5000";
            }
            else
            {
                txtmonto.Text = "10000";
            }
        }

        public void Limpia()
        {
            MessageBox.Show("Se han limpiado los espacios");
            txtdocumento.Clear();
            txtnombre.Clear();
            txtdocempresa.Clear();
            textBox1.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaorden();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu frm = new Menu();

            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void txtempresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdocempresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void consulta_Click(object sender, EventArgs e)
        {
            empresa();
        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresaOrden();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualiza_orden();
        }

        private void dtdatos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int documentocliente = Convert.ToInt32(this.dtdatos.SelectedRows[0].Cells[1].Value);
                string nombrecliente = this.dtdatos.SelectedRows[0].Cells[2].Value.ToString();
                int documentoempresa = Convert.ToInt32(this.dtdatos.SelectedRows[0].Cells[3].Value.ToString());
                string nombreempresa = this.dtdatos.SelectedRows[0].Cells[4].Value.ToString();
                string direccion = this.dtdatos.SelectedRows[0].Cells[5].Value.ToString();
                double monto = Convert.ToDouble(this.dtdatos.SelectedRows[0].Cells[7].Value.ToString());


                txtdocumento.Text = documentocliente.ToString();
                txtnombre.Text = nombrecliente;
                txtdocempresa.Text = documentoempresa.ToString();
                textBox1.Text = nombreempresa;
                txtdireccion.Text = direccion;
                txtmonto.Text = monto.ToString();


            }
            catch 
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private void dtdatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                try
                {
                    int documentocliente = Convert.ToInt32(this.dtdatos.SelectedRows[0].Cells[1].Value);
                    string nombrecliente = this.dtdatos.SelectedRows[0].Cells[2].Value.ToString();
                    int documentoempresa = Convert.ToInt32(this.dtdatos.SelectedRows[0].Cells[3].Value.ToString());
                    string nombreempresa = this.dtdatos.SelectedRows[0].Cells[4].Value.ToString();
                    string direccion = this.dtdatos.SelectedRows[0].Cells[5].Value.ToString();
                    double monto = Convert.ToDouble(this.dtdatos.SelectedRows[0].Cells[7].Value.ToString());


                    txtdocumento.Text = documentocliente.ToString();
                    txtnombre.Text = nombrecliente;
                    txtdocempresa.Text = documentoempresa.ToString();
                    textBox1.Text = nombreempresa;
                    txtdireccion.Text = direccion;
                    txtmonto.Text = monto.ToString();


                }
                catch 
                {
                    return;

                }

            }
        }

        private void dtdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            consultaord();
            Limpia();
        }

        private void consulta_out(object sender, EventArgs e)
        {
            empresa();
        }

        private void txtdocumento_MouseLeave(object sender, EventArgs e)
        {
            consultas();
        }

        private void txtdocumento_Leave(object sender, EventArgs e)
        {
            consultas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdocumento_MouseMove(object sender, MouseEventArgs e)
        {
            consultas();
        }

        private void txtdocumento_Move(object sender, EventArgs e)
        {
            consultas();
        }

        private void txtdocumento_LocationChanged(object sender, EventArgs e)
        {
            consultas();
        }
    }
}
