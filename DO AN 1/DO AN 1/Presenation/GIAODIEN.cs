using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_1.Presenation
{
    public class GD
    {
        public GD(int a,int b)
        {
            Console.SetWindowSize(a, b);
        }
        public void pain(string  a,int x,int y)
        {
            Console.SetWindowSize(100,45);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(a);
        }
        public void pain2(string  a, int x, int y)
        {
            Console.SetWindowSize(100,45);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(a);
        }
    }
}
