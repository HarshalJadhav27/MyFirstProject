using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class2
    {
        static void Main(string[] args)
        {
            // 2.Write a program to print all factors of given numbers

            int i;
            int fact = 1;
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factors of number"+ n +"="+fact);
        }
    }
}
