using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        List<SinhVien> dssv = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien();
                sv.MSSV = tbMSSV.Text;
                sv.Hoten = tbHT.Text;
                sv.Dienthoai = tbSDT.Text;
                sv.Diemtoan = float.Parse(tbDT.Text);
                sv.Diemvan = float.Parse(tbDV.Text);
                sv.DTB = (sv.Diemtoan + sv.Diemvan) / 2;
                if (sv.Dienthoai[0] != '0' && sv.Dienthoai.Length > 0)
                {
                    throw new Exception("Vui lòng nhập đúng định dạng của số điện thoại!");
                }    
                if (sv.Dienthoai.Length != 10  || !sv.Dienthoai.All(char.IsDigit))
                {
                    throw new Exception("Vui lòng nhập số điện thoại có 10 chữ số.");
                }
                if (sv.Diemtoan > 10 || sv.Diemtoan < 0)
                {
                    throw new Exception("Điểm toán không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                }
                if (sv.Diemvan > 10 || sv.Diemvan < 0)
                {
                    throw new Exception("Điểm văn không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
                }
                dssv.Add(sv);
                tbMSSV.Clear();
                tbHT.Clear();
                tbSDT.Clear();
                tbDV.Clear();
                tbDT.Clear();
                hienthiSV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        void hienthiSV()
        {
            lsDsSv.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.Hoten);
                item.SubItems.Add(sv.Dienthoai);
                item.SubItems.Add(sv.Diemtoan.ToString());
                item.SubItems.Add(sv.Diemvan.ToString());
                item.SubItems.Add(sv.DTB.ToString());
                lsDsSv.Items.Add(item);
            }
        }

        private void btnLuuF_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\input.txt";
            bool check = FileFactory.luuFile(dssv, path);
            if (check == true)
            {
                lsDsSv.Items.Clear();
                MessageBox.Show("Lưu file thành công!");
            }
             

        }

        private void btnDocF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            dssv = FileFactory.docFile(ofd.FileName);
            hienthiSV();
            MessageBox.Show("Đọc file thành công!");
            
        }
        private void btnGhiF_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\output.txt";
            bool check = FileFactory.luuFile(dssv, path);
            if (check == true)
            {
                MessageBox.Show("Ghi file thành công!");
            }
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            lsDsSv.View = View.Details;
            lsDsSv.Columns.Add("MSSV", 100);
            lsDsSv.Columns.Add("Họ tên", 100);
            lsDsSv.Columns.Add("Số điện thoại", 100);
            lsDsSv.Columns.Add("Điểm Toán", 100);
            lsDsSv.Columns.Add("Điểm Văn", 100);
            lsDsSv.Columns.Add("Điểm trung bình", 100);
        }

    }
}

