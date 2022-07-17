using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Countdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int Count = 0;

            while (n != 0)
            {
                int r = n % 10;
                sum = sum + r;
                Count++;

                n = n / 10;

            }
            Console.WriteLine(Count);
            

        }
    }
}
