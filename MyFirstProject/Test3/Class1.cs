using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class1
    {
        static void Main(string[] args)
        {
            /*Write a program to print all numbers 
            between 1 and 100 except the numbers which are divisible by 5or 10*/

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                    continue;
                Console.WriteLine(i);
            }


        }
    }
}
