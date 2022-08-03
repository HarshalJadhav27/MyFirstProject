using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class SumofPrime
    {
        int Prime(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                bool isprime = true;
               // int a = i;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    sum = sum + i;
                }
            }
            return sum;

        }
        static void Main(string[] args)
        {
            SumofPrime S = new SumofPrime();
            Console.WriteLine(S.Prime(20));

        }

    }
}
