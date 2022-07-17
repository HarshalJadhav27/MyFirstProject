using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Sumof_digit
    {
        static void Main(string[] args)
        {
            int n = 143;
            int a = n;
              
            int sum = 0;

            while(n!=0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;

            }
            Console.WriteLine($"Sum of digits {a} = {sum}");

        }
    }
}
