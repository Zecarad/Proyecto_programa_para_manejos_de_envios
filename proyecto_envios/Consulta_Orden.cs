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
    public partial class Consulta_Orden : Form
    {
        cls_negocios objenti = new cls_negocios();
        public Consulta_Orden()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            consultaord();
        }

        public void consultaord()
        {

            dt_consulta.DataSource = objenti.GetOrd();
        }


       public void consultanumero()
        {
            try { 
            objenti.Numero_orden = int.Parse(orden.Text.Trim());
            dt_consulta.DataSource = objenti.NumeroOrden();
        }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos con la inforamcion");
            }

}


        public void Eliminar_Orden()
        {
            try { 
            objenti.Documento_cliente = int.Parse(orden.Text.Trim());
            objenti.EliminarOrden();
            MessageBox.Show("La orden fue Eliminado exitosamente");
                }
            catch
            {
                MessageBox.Show("Debe llenar todos los campos con la inforamcion");
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
            consultanumero();
        }

        private void dt_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orden_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar_Orden();
        }
    }
}
