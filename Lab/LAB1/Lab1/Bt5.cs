using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class Bt5 : Form
    {
        public Bt5()
        {
            InitializeComponent();
        }

        private void Bt5_Load(object sender, EventArgs e)
        {

        }


        private void btXuat_Click(object sender, EventArgs e)
        {
            try
            {
                string[] danhSachDiem = (textBox1.Text).Split(' ');
                float tongDiem = 0;
                double dtb = 0;
                int dem1 = 0, dem2 = 0;
                float diemSo = 0;
                float[] dsDiem = new float[danhSachDiem.Length];
                if (danhSachDiem.Length > 12)
                {
                    throw new Exception("Dữ liệu đầu vào có tối đa 12 số thực.");
                }

                for (int i = 0; i < danhSachDiem.Length; i++)
                {
                    if (!float.TryParse(danhSachDiem[i], out diemSo))
                    {
                        throw new Exception($"Số thứ {i+1} không hợp lệ.");
                    }
                    if (diemSo < 0 || diemSo > 10)
                    {
                        throw new Exception($"Số thứ {i+1} phải nằm trong khoảng từ 0 đến 10.");
                    }
                    dsDiem[i] = diemSo;
                }
                for (int i = 1; i <= danhSachDiem.Length; i++)
                {
                    //Dùng để nhập một lượng lớn label tự động
                    Control[] foundControls = this.Controls.Find("label" + i, true);
                    if (foundControls.Length > 0 && foundControls[0] is Label)
                    {
                        Label currentLabel = (Label)foundControls[0];
                        //Hiển thị ra điểm của danh sách các môn
                        currentLabel.Text = "Môn " + i + ": " + danhSachDiem[i - 1] + "đ";
                    }
                }
                foreach (float diem in dsDiem)
                {
                    if (diem >= 5 && diem <= 10)
                    {
                        dem1++;
                    }
                    if (diem >= 0 && diem < 5)
                    {
                        dem2++;
                    }
                    tongDiem += diem;
                }
                soMonDau.Text = "Số môn đậu: " + dem1.ToString();
                soMonRot.Text = "Số môn không đậu: " + dem2.ToString();

                //diemTrungBinh.Text = "Điểm trung bình: " + (tongDiem/danhSachDiem.Length).ToString();
                dtb = Math.Round((tongDiem / danhSachDiem.Length), 2);
                diemTrungBinh.Text = "Điểm trung bình: " + dtb.ToString();

                float diemMax = float.Parse(danhSachDiem[0]);
                float diemMin = float.Parse(danhSachDiem[0]);

                for (int i = 0; i < danhSachDiem.Length; i++)
                {
                    if (float.Parse(danhSachDiem[i]) >= diemMax)
                    {
                        diemMax = float.Parse(danhSachDiem[i]);
                    }
                    if (float.Parse(danhSachDiem[i]) <= diemMin)
                    {
                        diemMin = float.Parse(danhSachDiem[i]);
                    }
                }
                monDiemMax.Text = "Môn có điểm cao nhất: " + diemMax.ToString() + "đ";
                monDiemMin.Text = "Môn có điểm thấp nhất: " + diemMin.ToString() + "đ";
                if (dtb >= 8 && diemSo >= 6.5)
                {
                    xepLoaiHocLuc.Text = "Xếp loại học lực: Giỏi";
                }
                else if (dtb >= 6.5 && diemSo >= 5)
                {
                    xepLoaiHocLuc.Text = "Xếp loại học lực: Khá";
                }
                else if (dtb >= 5 && diemSo >= 3.5)
                {
                    xepLoaiHocLuc.Text = "Xếp loại học lực: TB";
                }
                else if (dtb >= 3.5 && diemSo >= 2)
                {
                    xepLoaiHocLuc.Text = "Xếp loại học lực: Yếu";
                }
                else
                {
                    xepLoaiHocLuc.Text = "Xếp loại học lực: Kém";
                }
                MessageBox.Show("Xuất danh sách điểm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
