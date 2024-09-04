using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Лабораторная_работа_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            line l1 = new line();
            l1.A = -0.5;
            l1.B = 3;
            l1.Print();
            l1.Ox();
            l1.Oy();

            line l2 = new line();
            l2.A = 2;
            l2.B = 6;
            l2.Print();
            l2.Ox();
            l2.Oy();

            l1.Vertical(l1.A, l2.A);
            l1.Corner(l1.A, l2.A, l1.B, l2.B);
        }
    }
}
