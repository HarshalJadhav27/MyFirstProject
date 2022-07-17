using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());

            bool prime = true;

            for(int i= 2;i<=a/2;i++)
            {
                if(a % i==0)
                {
                    prime = false;

                }
                 
            }
            if (prime == false)
            {
                Console.WriteLine("not prime");
            }
            else
            {
                Console.WriteLine("prime");
            }
        }   


    }
}
