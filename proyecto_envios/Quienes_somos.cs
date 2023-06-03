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
    public partial class Quienes_somos : Form
    {
        public Quienes_somos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu frm = new Menu();

            frm.Show();
        }
    }
}
