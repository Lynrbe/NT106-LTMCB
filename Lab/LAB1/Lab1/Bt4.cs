using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class Bt4 : Form
    {
        public Bt4()
        {
            InitializeComponent();
        }
        string num_hex = "";
        string num_bin = "";
        string num_dec = "";
        ComboBox Origin_num = new ComboBox();
        ComboBox Destinate_num = new ComboBox();
        Regex regex_hex = new Regex("^[0-9A-Fa-f]+$");
        Regex regex_bin = new Regex("^[0-1]+$");


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Origin_num = (ComboBox)sender;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Destinate_num = (ComboBox)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Origin_num.Text == "" || Destinate_num.Text == "" || tbNumber.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Origin_num.Text == "Decimal")
                {
                    int middle = int.Parse(tbNumber.Text);
                    num_bin = Convert.ToString(middle, 2);
                    num_hex = Convert.ToString(middle, 16);
                    num_dec = tbNumber.Text;
                }
                else if (Origin_num.Text == "Binary")
                {
                    string middle = tbNumber.Text;
                    if (!regex_bin.IsMatch(middle))
                    {
                        MessageBox.Show("Giá trị không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        num_bin = tbNumber.Text;
                        num_dec = Convert.ToString(Convert.ToInt32(middle, 2), 10);
                        num_hex = Convert.ToString(Convert.ToInt32(middle, 2), 16);
                    }
                }
                else
                {
                    string middle = tbNumber.Text;
                    if (!regex_hex.IsMatch(middle))
                    {
                        MessageBox.Show("Giá trị không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        num_bin = Convert.ToString(Convert.ToInt32(middle, 16), 2);
                        num_dec = Convert.ToString(Convert.ToInt32(middle, 16), 10);
                        num_hex = tbNumber.Text;
                    }
                }
                if (Destinate_num.Text == "Decimal")
                {
                    kq.Text = num_dec;
                }
                else if (Destinate_num.Text == "Binary")
                {
                    kq.Text = num_bin;
                }
                else
                {
                    kq.Text = num_hex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không?");
            tbNumber.Clear();
            kq.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

