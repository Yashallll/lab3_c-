using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_3
{
    internal class line
    {
        public double A { get; set; }
        public double B { get; set; }
        public void Print()//вывод функции
        {
            Console.WriteLine($"Уравнение: y = {A}x + {B}");
        }
        public void Ox()//пересечение Ox
        {
            double ox = -B/A;
            Console.WriteLine($"Пересечение с Ox: y = 0, x = {ox}");
        }
        public void Oy()//пересечение Oy
        {
            double oy = B;
            Console.WriteLine($"Пересечение с Oy: x = 0, x = {oy}");
        }
        public void Vertical(double a1, double a2)//перпенд. прямых
        {
            if (a1 == (-1/a2))
            {
                Console.WriteLine("Прямые перпендикулярны!");
            }
            else Console.WriteLine("Прямые не перпендикулярны!");
        }
        public void Corner(double a1, double a2, double b1, double b2)//угол между прямыми
        {
            double x = ((a2 - a1) / (1 + a1 * a2));
            double y = Math.Atan(x);
            y = y*180/Math.PI;
            y *= 100;
            y = (int)y / 100.0;
            Console.WriteLine($"Угол между прямыми равен:{y} градусов!");
        }
    }
}
