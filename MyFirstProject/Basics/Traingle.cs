using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class Traingle
    {
        static void Main(string[] args)
        {
            // console.writeline("Calculate Area Of Traingle")is

            int length, height;

            length = 10;
            height = 5;

            float area = 0.5f * length * height;
            Console.WriteLine("area=" + area);
        }
    }
}
