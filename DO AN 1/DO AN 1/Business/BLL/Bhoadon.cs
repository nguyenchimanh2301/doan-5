using DO_AN_1.DataAccessLayer;
using DO_AN_1.Entities;
using System.IO;
using System.Linq;
using DO_AN_1.Utility;
using System.Text;

namespace DO_AN_1.Business.BLL
{
    class Bhoadon
    {
        DALhoadon HDDAL = new DALhoadon();
        public list<Hoadon> hoadon()
        {
            list<Hoadon> hd = HDDAL.readlist("Data/Hoadon.txt");
            return hd;
        }
        public void them(Hoadon h)
        {
           list<Hoadon> ds = HDDAL.readlist("Data/Hoadon.txt");
            Node<Hoadon> tg = ds.Head;
            ds.addhead(h);
            HDDAL.writelist("Data/Hoadon.txt", ds);
        }
        public double tongtien()
        {
            list<Hoadon> ds = HDDAL.readlist("Data/Hoadon.txt");
            double tong = 0;
            Node<Hoadon> tg = ds.Head;
            while(tg!=null)
            {
                tong = tong + tg.Data.Tongt;
                tg = tg.Link;
            }
            return tong;
        }
    }
}
