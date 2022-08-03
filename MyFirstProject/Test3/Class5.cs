using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class5
    {
        static void Main(string[] args)
        {
            /* 5.To find whether the given number is a Harshad number or not, calculate \n
                 the sum of the digit of the number then,\n
                 check whether the given number is divisible by \n
                 the sum of its digit.If yes, then given number is a Harshad number.*/

            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = n;

            while (n > 0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;

            }
            n = a;
            Console.WriteLine("sum of digit =" + sum);
            Console.WriteLine("Given number= "+ n);
            if (n % sum == 0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not harshad number");
            }

        }
    }
}
