using System;
using System.Collections.Generic;
using DO_AN_1.Utility;
using DO_AN_1.Presenation;
using DO_AN_1.DataAccessLayer;
using DO_AN_1.Entities;

namespace DO_AN_1.Business.BLL
{
    class Bphongkt
    {
        DALphongkt PDAL = new DALphongkt();
        public list<Phongkt> LPhong()
        {
            list<Phongkt> dsp = PDAL.readlist("Data/Phong.txt");
            return dsp;
        }

        public void themphong(Phongkt p)
        {
            list<Phongkt> ph = PDAL.readlist("Data/Phong.txt");
            Node<Phongkt> tg = ph.Head;
            p.Tenday = congcu.chuanhoaxau(p.Tenday);
            p.Maph = congcu.chuanhoaxau(p.Maph);
            p.Maph = congcu.chuanhoaxau(p.Maph);
            ph.addhead(p);
            PDAL.writelist("Data/Phong.txt", ph);
        }
        public bool ktmap(string maphong)
        {
            list<Phongkt> ph = PDAL.readlist("Data/Phong.txt");
            Node<Phongkt> tg = ph.Head;
            bool kt = true;
            while (tg != null)
            {
                if (tg.Data.Maph == maphong)
                {
                    kt = false;
                    break;
                }
                tg = tg.Link;
            }
            return kt;
        }
        public Phongkt timtheoma(string maphong)
        {
            list<Phongkt> ph = PDAL.readlist("Data/Phong.txt");
            Node<Phongkt> tg = ph.Head;
            Phongkt p = new Phongkt();
            while (tg != null)
            {
                if (tg.Data.Maph == maphong)
                {
                    p = tg.Data;
                    break;

                }
                else
                    tg = tg.Link;
            }
            return p;
        }
        public int tongsinhvien()
        {
            list<Phongkt> ph = PDAL.readlist("Data/Phong.txt");
            Node<Phongkt> tg = ph.Head;
            int tong = 0;
            while (tg != null)
            {
                tong = tong + tg.Data.Dango;
                tg = tg.Link;
            }
            return tong;
        }
    }
}