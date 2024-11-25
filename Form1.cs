namespace WinFormsAppVariasImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Primavera_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsAppVariasImagenes.Properties.Resources.primavera;
        }

        private void Verano_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsAppVariasImagenes.Properties.Resources.verano;
        }

        private void Invierno_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormsAppVariasImagenes.Properties.Resources.invierno;
        }
    }
}
