using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable]
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string Hoten { get; set; }   
        public string Dienthoai { get; set; }
        public float Diemtoan { get; set; }
        public float Diemvan { get; set; }
        public float DTB { get; set; }
        public override string ToString()
        {
            return MSSV + "\n" + Hoten + "\n" + Dienthoai + "\n" + Diemtoan + "\n" + Diemvan + "\n" + DTB;
        }
    }
}
