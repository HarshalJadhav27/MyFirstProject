using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class PrimeMethod
    {
        bool Even(int n)
        {
            // int sum = 0;
            //int 
            // return false;
            bool a = false;
            if (n % 2 == 0 && n % 2 == 1)
            {
                a = true;
            }

            else if (n % 2 == 1)
            {
                Console.WriteLine("Prime Numbers");
            }
            else
            {
                Console.WriteLine("Not prime numbers");
            }
            return a;

            // return true;
            // Console.WriteLine("Even number and Prime number");

        }






        static void Main(string[] args)
        {
            PrimeMethod p = new PrimeMethod();
            Console.WriteLine(p.Even(2));

        }


    }
}