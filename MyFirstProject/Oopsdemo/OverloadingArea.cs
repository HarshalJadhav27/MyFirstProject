using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class OverloadingArea
    {
        int Area(int l, int w)
        {
            return (l*w);
        }
        double Area(double b, double h)
        {
            return (b * h)/ 2;
        }
        int Area(int s)
        {
            return (s*s);
        }
        double Area(double r)
        {
            return (3.14*r*r);
        }
        static void Main(string[] args)
        {
            OverloadingArea A = new OverloadingArea();
            Console.WriteLine("Area of Rectangle" + A.Area(8,5));
            Console.WriteLine("Area of Traingle " + A.Area(3.5,8.2));
            Console.WriteLine("Area of Square " + A.Area(8));
            Console.WriteLine("Area of Ciecle " + A.Area(6.4));

        }
    }
}
