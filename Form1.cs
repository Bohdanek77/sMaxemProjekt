namespace sMaxemProjekt
{
    public partial class Form1 : Form
    {
        public var priklad = label1.Text;
        public Form1()
        {
            InitializeComponent();
            label1.Text = priklad;
            vysledek.Text = "";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = vysledek.ToString();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void vysledek_Click(object sender, EventArgs e)
        {

        }
    }
}
