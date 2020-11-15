using DO_AN_1.Entities;
using DO_AN_1.Utility;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using DO_AN_1.Presenation;

namespace DO_AN_1.DataAccessLayer
{
    class DALhoadon
    {
        DALhelp dah = new DALhelp("Data/Hoadon.txt");
        public string HDON(Hoadon d)
        {
            return d.Maph + "#" + d.Tienphong + "#" + d.Tiendien + "#" + d.Tiennuoc + "#" + d.Tienvesinh + "#" + d.Tgiano + "#" + d.Tkhac+"#"+d.Tongt;
        }
        public Hoadon HOADON(string s)
        {
            s = congcu.catxau(s);
            string[] tmp = s.Split('#');
            Hoadon h = new Hoadon(tmp[0], double.Parse(tmp[1]), double.Parse(tmp[2]), double.Parse(tmp[3]), double.Parse(tmp[4]), int.Parse(tmp[5]), double.Parse(tmp[6]),double.Parse(tmp[7]));
            return h;
        }
        public void writefile(string filename, Hoadon d)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(HDON(d));
            sw.Close();
            fs.Close();
        }
        public Hoadon readfile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            return HOADON(read);
        }
        public  void writelist(string filename,list<Hoadon> hd)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Hoadon> h = hd.Head;
            while (h!=null)
            {
                sw.WriteLine((HDON(h.Data)));
                h = h.Link;
            }
            sw.Close();
            fs.Close();
        }
        public list<Hoadon> readlist(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            list<Hoadon> list = new list<Hoadon>();
            string s = sr.ReadLine();
            while(s!=null)
            {
                if (s != "")
                {
                    list.addtail(HOADON(s));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return list;
        }
      
    }
}
