using DO_AN_1.Entities;
using DO_AN_1.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DO_AN_1.DataAccessLayer
{
    class DALdangnhap
    {
        DALhelp dah = new DALhelp("Data/Login.txt");
        public string ACC(Dangnhap d)
        {
            return d.Taikhoan + "#" + d.Matkhau;
        }
        public Dangnhap ACOUNT(string s)
        {
            s = congcu.catxau(s);
            string [] tmp=s.Split('#');
            Dangnhap login = new Dangnhap(tmp[0], tmp[1]);
            return login;
        }
        public void writefile(string filename,Dangnhap d)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(ACC(d));
            sw.Close();
            fs.Close();
        }
        public Dangnhap readfile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            return ACOUNT(read);
        }
    }
}
