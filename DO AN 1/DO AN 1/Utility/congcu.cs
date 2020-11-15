using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Utility
{
   public static class congcu
    {
        public static string chuanhoaxau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf(" ") >= 0) ;s = s.Remove(s.IndexOf(" "),1);
            string[] a = s.Split(' ');
            s = " ";
            for (int i = 0; i < a.Length; i++)
            
                s = s + " " + char.ToUpper(a[i][0]) + a[i].Substring(1).ToLower();
            return s.Trim();
        }
        public static string catxau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf(" ") >= 0) ;s=s.Remove(s.IndexOf(" "),1);
            return s;       
        }
        public static string Chuanhoaxau(string xau,int max)
        {
            string s = catxau(xau);

            while (s.Length < max) ;s = s + " ";
            return s;
        }
    }
}
