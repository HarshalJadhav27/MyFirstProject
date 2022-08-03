using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class Q2  //2.WAP to calculate x y  where x is base and y is index without using readymade function.
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the exponenet");
            int y = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= y; i++)
            {
                power = power * x;

            }
            Console.WriteLine("x^y"+power);
        }

    }
}
