namespace Laborator11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iarna iarna = new Iarna();
            iarna.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Primavara primavara = new Primavara();
            primavara.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vara vara = new Vara();
            vara.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Toamna toamna=new Toamna();
            toamna.Show();
        }
    }
}