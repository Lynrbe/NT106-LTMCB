using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btB1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
            bai1 = null;
            this.Show();
        }

        private void btB2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
            bai2 = null;
            this.Show();
        }
    }
}
