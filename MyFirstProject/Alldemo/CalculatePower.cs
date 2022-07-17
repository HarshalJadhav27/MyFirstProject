using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunda28_June.Loops
{
    class CalculatePower
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine(Math.Pow(4,3));
            Console.WriteLine("Enter the base");
            int base_number = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent");
            int expo = int.Parse(Console.ReadLine());

            int power = 1;

            for(int i=1;i<=expo;i++)
            {
                power = power * base_number;
            }

            Console.WriteLine(power);



        }
    }
}
