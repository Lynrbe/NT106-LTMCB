namespace Lab1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bt1 b1 = new Bt1(); ;
            b1.ShowDialog();
            b1 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bt2 b2 = new Bt2();
            b2.ShowDialog();
            b2 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bt3 b3 = new Bt3();
            b3.ShowDialog();
            b3 = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bt4 b4 = new Bt4();
            b4.ShowDialog();
            b4 = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bt5 b5 = new Bt5();
            b5.ShowDialog();
            b5 = null;
            this.Show();
        }
    }
}