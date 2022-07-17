using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Reversedemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            //n = 134;

            while (n > 0)
            {
                int r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
