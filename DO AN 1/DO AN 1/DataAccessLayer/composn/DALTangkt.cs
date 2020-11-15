using DO_AN_1.Presenation;
using DO_AN_1.Entities;
using System.IO;
using DO_AN_1.Utility;
using System.Collections.Generic;
using System.Text;
namespace DO_AN_1.DataAccessLayer.composn
{
    class DALTangkt
    {
        DALhelp dah = new DALhelp("Data/Tangkituc.txt");
        public string Tang(Tangkt k)
        {
            return k.Tenttang + "#" + k.Slphong;
        }
        public Tangkt TANG(string t)
        {
            t = congcu.catxau(t);
            string[] tmp = t.Split("#");
            Tangkt ta = new Tangkt(tmp[0], int.Parse(tmp[1]));
            return ta;
        }
        public void writefile(string filename, Tangkt t)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(Tang(t));
            sw.Close();
            fs.Close();
        }
        public Tangkt readfile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string read = sr.ReadLine();
            return TANG(read);
        }
        public void writelist(string filename, list<Tangkt> k)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Node<Tangkt> ta = k.Head;
            while (ta != null)
            {
                sw.WriteLine((Tang(ta.Data)));
                ta = ta.Link;
            }
            sw.Close();
            fs.Close();
        }
        public list<Tangkt> readlist(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            list<Tangkt> list = new list<Tangkt>();
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != null)
                {
                    list.addtail(TANG(s));

                }
                s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return list;
        }
    }
}
