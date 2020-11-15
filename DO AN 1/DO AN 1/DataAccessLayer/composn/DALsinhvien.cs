using DO_AN_1.Presenation;
using DO_AN_1.Utility;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.DataAccessLayer
{
    class DALsinhvien
    {
        DALhelp dah = new DALhelp("Data/Sinhvien.txt");
        public string SV(Sinhvien sv)
        {
            return sv.Maph+"#"+ sv.Masv + "#" + sv.Tensv + "#"+sv.Gioitinh+"#" + sv.Tenlop + "#" + sv.Diachi + "#" + sv.Sdt1;
        }
        public Sinhvien SSV(string s)
        {
            s = congcu.catxau(s);
            string[] tmp = s.Split('#');
            Sinhvien sv = new Sinhvien(tmp[0], tmp[1], tmp[2], tmp[3],tmp[4],tmp[5],tmp[6]);
            return sv;
        }
        public void writefile(string filename, Sinhvien sv)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(SV(sv));
            sw.Close();
            fs.Close();
        }
        public Sinhvien readfile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            return SSV(read);
        }
        public void writelist(string filename,list<Sinhvien> sv)
        {

            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Sinhvien> s = sv.Head;
            while (s != null)
            {
                sw.WriteLine((SV(s.Data)));
                  s= s.Link;
            }
            sw.Close();
            fs.Close();
        }
        public list<Sinhvien> readlist(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            list<Sinhvien> list = new list<Sinhvien>();
            string s = sr.ReadLine();
            while(s!=null)
            {
                if(s!="")
                {
                    list.addtail(SSV(s));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return list;
        }
    }
}

