using System.Text;
using System.Linq;
using DO_AN_1.Utility;
using DO_AN_1.Presenation;
using DO_AN_1.DataAccessLayer;

namespace DO_AN_1.Business.BLL
{
    class Bsinhvien
    {
        DALsinhvien DALSV = new DALsinhvien();
        public list<Sinhvien> SV()
        {
            list<Sinhvien> sv = DALSV.readlist("Data/Sinhvien.txt");
            return sv;
        }
        public void Them(Sinhvien sv)
        {
            list<Sinhvien> ds = DALSV.readlist("Data/Sinhvien.txt");
            Node<Sinhvien> tg = ds.Head;
            sv.Tensv = congcu.chuanhoaxau(sv.Tensv);
            sv.Masv = congcu.chuanhoaxau(sv.Tensv);
            sv.Gioitinh = congcu.chuanhoaxau(sv.Gioitinh);
            sv.Diachi = congcu.chuanhoaxau(sv.Diachi);
            sv.Tenlop = congcu.catxau(sv.Tenlop);
            sv.Sdt1 = congcu.catxau(sv.Sdt1);
            ds.addhead(sv);
            DALSV.writelist("Data/Sinhvien.txt", ds);
        }
        public void xoasinhvien(string maSV)
        {
            list<Sinhvien> listsv = DALSV.readlist("Data/Sinhvien.txt");
            Node<Sinhvien> tg = listsv.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == maSV)
                {
                    listsv.xoaq(tg);
                    break;
                }
                else
                    tg = tg.Link;
            }
            DALSV.writelist("Data/Sinhvien.txt", listsv);
        }
        public void suattsv(string masv)
        {
            list<Sinhvien> lsv = DALSV.readlist("Data/Sinhvien.txt");
            Node<Sinhvien> tg = lsv.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == masv)
                {
                    break;
                }
                else
                    tg = tg.Link;
            }
            DALSV.writelist("Data/Sinhvien.txt", lsv);
        }
        public Sinhvien timtheoma(string masv)
        {
            list<Sinhvien> lsv = DALSV.readlist("Data/Sinhvien.txt");
            Node<Sinhvien> tg = lsv.Head;
            while (tg != null)
            {
                if (tg.Data.Masv == masv)
                {
                    break;
                }
                else
                    tg = tg.Link;
            }
            Sinhvien sv = new Sinhvien(tg.Data);
            return sv;
        }
        public list<Sinhvien> tmtheoten(string tensv)
        {
            list<Sinhvien> lsv = DALSV.readlist("Data/Sinhvien.txt");
            list<Sinhvien> listsv = new list<Sinhvien>();
            Node<Sinhvien> tg = lsv.Head;
            while (tg != null)
            {
                if (tg.Data.Tensv.ToUpper() == tensv.ToUpper())
                {
                    listsv.addhead(tg.Data);
                    tg = tg.Link;
                }
                else
                    tg = tg.Link;
            }
            return listsv;
        }
        public bool kiemtrahten(string tensv)
        {
            bool kt = false;
            for (int i = 0; i < tensv.Length; i++)
            {
                if(tensv[i] == '0' || tensv[i]=='1'|| tensv[i] == '2' || tensv[i] == '3' || tensv[i] == '4' || tensv[i] == '5' || tensv[i] == '6' || tensv[i] == '7' || tensv[i] == '8' || tensv[i] == '9')
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        public bool kiemtragt(string masv)
        {
            bool kt = false;
            list<Sinhvien> lsv = DALSV.readlist("Data/Sinhvien.txt");
            Node<Sinhvien> tg = lsv.Head;
            while(tg!=null)
            {
                if (tg.Data.Masv == masv)
                {
                    if (tg.Data.Gioitinh.ToUpper() == "NAM")
                    {
                        kt = true; break;
                    }
                    break;
                }
                else
                    tg = tg.Link;
            }
            return kt;
        }
        //public list<Sinhvien> timtheophong(string maphong)
        //{
        //    list<Sinhvien> lsv = DALSV.readlist("Data/Sinhvien.txt");
        //    list<Sinhvien> listsv = new list<Sinhvien>();

        //    Node<Sinhvien> tg = lsv.Head;
        //    Node<int> tg1 = listsv
        //    while (tg != null)
        //    {
        //        if (tg.Data.Maph.ToUpper() == maphong.ToUpper())
        //        {
        //            listsv.addhead(tg.Data);
        //            tg = tg.Link;
        //        }
        //        else
        //            tg = tg.Link;
        //    }
        //    return listsv;
        
    }
}
    

