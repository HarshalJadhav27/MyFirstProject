using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class4
    {
        static void Main(string[] args)
        {
            // 4.WAP to print fibbo series upto 20 terms

            int next;
            int first = 0;
            int second = 1;

           // Console.WriteLine("Enter the range");
           // int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 20; i++)
            {
                if (i <= 1)
                {
                    next = i;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;


                }
                Console.WriteLine("\t" + next);
            }
            Console.ReadLine();
        }
    }
}
