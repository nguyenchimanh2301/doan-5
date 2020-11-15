using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Entities
{
    class TKhoan
    {
        private string taikhoan, matkhau;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public TKhoan(TKhoan t)
        {
            this.taikhoan = t.taikhoan;
            this.matkhau = t.matkhau;
        }
        public TKhoan(string taikhoan,string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
    }
}
