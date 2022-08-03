using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                if(r%2==0)
                {
                    sum = sum + r;
                }
                num = num / 10;

            }
           

            Console.WriteLine(sum);



        }
    }
}
