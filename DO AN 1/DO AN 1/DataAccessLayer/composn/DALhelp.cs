using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DO_AN_1.DataAccessLayer
{
    class DALhelp
    {
        private string filename;
        public string Filename { get => filename; 
            set { if (filename != " ") filename = value; } }
        public DALhelp(string filename)
        {
            this.filename = filename;
        }
        public DALhelp() { }
        public void write(string writ)
        {
            StreamWriter s = new StreamWriter(filename);
            s.Write(writ);
            s.Dispose();
        }
        public void remove()
        {
            StreamWriter sw = new StreamWriter(Filename);
            sw.Write(" "); ;
            sw.Dispose();

        }
      
    }
}
