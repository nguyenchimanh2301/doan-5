using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Entities
{
    class Hoadon
    {
        private string maph;
        private double tienphong;
        private double tiennuoc;
        private double tienvesinh;
        private int tgiano;
        private double tkhac;
        private double tiendien;
        private double tongt;

        public string Maph { get => maph; set => maph = value; }
        public double Tienphong { get => tienphong; set => tienphong = value; }
        public double Tiennuoc { get => tiennuoc; set => tiennuoc = value; }
        public double Tienvesinh { get => tienvesinh; set => tienvesinh = value; }
        public int Tgiano { get => tgiano; set => tgiano = value; }
        public double Tkhac { get => tkhac; set => tkhac = value; }
        public double Tiendien { get => tiendien; set => tiendien = value; }
        public double Tongt { get => tongt; set => tongt = value; }

        public Hoadon(Hoadon d)
        {
            this.maph = d.Maph;
            this.tienphong = d.Tienphong;
            this.tienvesinh = d.Tienvesinh;
            this.tkhac = d.Tkhac;
            this.tgiano = d.Tgiano;
            this.tiennuoc = d.Tiennuoc;
            this.tiendien = d.Tiendien;
            this.tongt = d.tongt;
        }
        public Hoadon(string maph,double tienphong, double tiendien, double tiennuoc, double tienvesinh, int tgiano, double tkhac,double tongt)
        {
            this.maph = maph;
            this.tienphong = tienphong;
            this.tienvesinh = tienvesinh;
            this.tkhac = tkhac;
            this.tgiano = tgiano;
            this.tiendien = tiendien;
            this.tiennuoc = tiennuoc;
            this.tongt = tongt;
        }
    }


}
