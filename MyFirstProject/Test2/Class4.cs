using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class4
    {
        static void Main(string[] args)
        {
            //check num is spy or not
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int a = num;
            int sum = 0;
            int mul = 1;
            while(num!=0)
            {
               int  r = num % 10;
                sum = sum + r;
                mul = mul * r;
                num = num / 10;

            }
            num = a;
            if (sum == mul)
            {
                Console.WriteLine("Number is spy");
            }
            else
            {
                Console.WriteLine("Number is not spy");
            }

        }
    }
}
