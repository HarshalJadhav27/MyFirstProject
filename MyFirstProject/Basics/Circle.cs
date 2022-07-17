using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class Circle
    {
        static void Main(string[] args)
        {
            //console.writeline("Calculate area of circle")is

            int radius;

            radius = 2;
            float pi = 3.14f;

            float area = radius*radius * pi;
            Console.WriteLine("area=" + area);
        }
    }
}
