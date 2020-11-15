using System.Text;
using System.Linq;
using DO_AN_1.Utility;
using DO_AN_1.Presenation;
using DO_AN_1.DataAccessLayer.composn;
using DO_AN_1.Entities;
using DO_AN_1.Business;

namespace DO_AN_1.Business.BLL
{
    class Btangkt
    {
        DALTangkt DALTANG = new DALTangkt();
        public list<Tangkt> LTANG()
        {
            list<Tangkt> lt = DALTANG.readlist("Data/Tangkituc.txt");
            return lt;
        }
        public void them(Tangkt t)
        {
            list<Tangkt> lt = DALTANG.readlist("Data/Tangkituc.txt");
            Node<Tangkt> tg = lt.Head;
            lt.addhead(t);
            DALTANG.writelist("Data/Tangkituc.txt", lt);
        }
        public int tongphong()
        {
            list<Tangkt> lt = DALTANG.readlist("Data/Tangkituc.txt");
            Node<Tangkt> tg = lt.Head;
            int tp = 0;
            while (tg!=null)
            {
                tp = tp + tg.Data.Slphong;
            }
            return tp;
        }
    }
}
