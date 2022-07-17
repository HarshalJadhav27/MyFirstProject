using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
           
            int sum = 0;
            int a = n;

            //12121

            while(n>0)
            {
                int r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            n = a;

            Console.WriteLine(sum);
            if(n==sum)
            {
                Console.WriteLine("Palindrome number"); 
            }
            else
            {
                Console.WriteLine("Not palindrome number");
            }
        }
    }
}
