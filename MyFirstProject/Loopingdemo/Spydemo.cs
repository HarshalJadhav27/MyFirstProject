using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Spydemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int mul = 1;

            //123

            while (n > 0)
            {
                int r = n % 10;
                sum = sum + r;
                mul = mul * r;
                n = n / 10;
            }
            Console.WriteLine(sum);
            if (mul == sum)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine("Not Spy number");
            }
        }
    }
}
