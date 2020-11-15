using System;
using System.Text;
using DO_AN_1.Business;
using DO_AN_1.Utility;
using DO_AN_1.DataAccessLayer;
using DO_AN_1.Entities;

namespace DO_AN_1.Business
{
    class DangnhapB
    {
        DALdangnhap dn = new DALdangnhap();
        public bool kiemtratk(string taikhoan, string matkhau)
        {
            Dangnhap d = dn.readfile("Data/Login.txt");
            bool kt = false;
            if(d.Taikhoan=="KTX" && d.Matkhau=="SPKT")
            {
               kt=true;
            }
            return kt;
        }
    }
}
