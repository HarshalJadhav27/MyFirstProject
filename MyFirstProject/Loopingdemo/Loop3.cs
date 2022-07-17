using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Loop3
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Math.Pow(4,3));

            Console.WriteLine("Enter the base");
            int base_num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the exponent");
            int expo = int.Parse(Console.ReadLine());

            int Power = 1;

            for(int i = 1;i<=expo;i++)
            {
                Power = Power * base_num;
            }
            Console.WriteLine(Power);


        }
    }
}
