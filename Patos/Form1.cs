namespace Patos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerPatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPatos telaPatos = new FormPatos();
            telaPatos.FormClosed += (s, args) => this.Close();
            telaPatos.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
