using DO_AN_1.Entities;
using DO_AN_1.Utility;
using System.IO;
using System.Text;
using System.ComponentModel;

namespace DO_AN_1.DataAccessLayer
{
    class DALphongkt
    {
        DALhelp dah = new DALhelp("Data/Phong.txt");
        public string Phong(Phongkt t)
        {
            return t.Maph + "#" + t.Tenday + "#" + t.Soluongmax + "#" + t.Dango + "#" + t.Tinhtrang;
        }
        public Phongkt PH(string p)
        {
            p = congcu.catxau(p);
            string[] tmp = p.Split("#");
            Phongkt t = new Phongkt(tmp[0], tmp[1], int.Parse(tmp[2]), int.Parse(tmp[3]),tmp[4]);
            return t;
        }
        public void writefile(string filename,Phongkt t)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(Phong(t));
            sw.Close();
            fs.Close();
        }
        public Phongkt  readfile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            return PH(read);
        }
        public void writelist(string filename,list<Phongkt> p)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Phongkt> ph  = p.Head;
            while(ph!=null)
            {
                sw.WriteLine((Phong(ph.Data)));
                ph = ph.Link;
            }
            sw.Close();
            fs.Close();
        }
        public list<Phongkt> readlist(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            list<Phongkt> list = new list<Phongkt>();
            string s = sr.ReadLine();
            while(s!=null)
            {
                if(s!=null)
                {
                    list.addtail(PH(s));
                    
                }
                s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return list;
        }
    } 
}
