using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swichdemo
{
    class Areademo
    {
        static void Main()
        {
            Console.WriteLine("Enter radius");

            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter length");

            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter length of the base");
            int baselength = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Area of circle\n2.Area of rectangle\n3.Area of traingle");
            Console.WriteLine("Enter Your Choice");
            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)

            {
                case 1:
                    Console.WriteLine("Area of circle= " + (3.14f * radius*radius));
                    break;

                case 2:
                    Console.WriteLine("Area of rectangle= " + (length * width));
                    break;

                case 3:
                    Console.WriteLine("Multiplication= " + (0.5 * baselength * height));
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }
    }
}
