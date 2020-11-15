using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Entities
{
    class Dangnhap
    {
        private string taikhoan, matkhau;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public Dangnhap(Dangnhap t)
        {
            this.taikhoan = t.taikhoan;
            this.matkhau = t.matkhau;
        }
        public Dangnhap(string taikhoan,string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
    }
}
