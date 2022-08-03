using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q11
    {       // Correct IMEI number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            long a = long.Parse(Console.ReadLine());
            long sum = 0;
            long n = a;

            while (a > 0)
            {
                long r = a % 10;
                sum = sum + r;
                a = a / 10;

            }
            a = n;
            Console.WriteLine(sum);
            if (sum % 10 == 0)
            {
                Console.WriteLine("Correct IMEI Number");
            }
            else
            {
                Console.WriteLine("Invalid IMEI Number");
            }
        }
    }
}
