using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Entities
{
     class Tangkt
    {
        private string tentang;
        private int slphong;

        public string Tenttang { get => tentang; set => tentang = value; }
        public int Slphong { get => slphong; set => slphong = value; }
        public Tangkt(Tangkt k)
        {
            this.tentang = k.tentang;
            this.slphong = k.slphong;
        }
        public Tangkt(string tentang,int slphong)
        {
            this.slphong = slphong;
            this.tentang = tentang;
        }
    }
}
