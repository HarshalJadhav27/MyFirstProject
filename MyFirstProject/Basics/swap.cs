using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class swap
    {
        static void Main(string[] args)
        {
            // console.writeline("Swap the 2 numbers")

            

            Console.WriteLine("Enter 1 st number");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            int b = int.Parse(Console.ReadLine());  //  Convert.To32(Console.ReadLine())


            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);




        }
    }
}
