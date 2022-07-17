using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test
{
    class Class1
    {
        static void Main(string[] args)
        {
            // Calculate area of equilateral triangle

            //In Equilateral triangle all sides must be equal

            Console.WriteLine("Enter The Length of Side ");
            int s = int.Parse(Console.ReadLine());

            double Area = 1.732*0.25*s*s;
            {
                Console.WriteLine("Area\t" + Area);
            }
           
        }
    }
}
