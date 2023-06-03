namespace proyecto_envios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Creacion_orden frm = new Creacion_orden();

            frm.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login frm = new Login();

            frm.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Consulta_Orden frm = new Consulta_Orden();

            frm.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Empresas frm = new Empresas();

            frm.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Clientes frm = new Clientes();

            frm.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Quienes_somos frm = new Quienes_somos();

            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();

            AgregarUsuario frm = new AgregarUsuario();

            frm.Show();
        }
    }
}