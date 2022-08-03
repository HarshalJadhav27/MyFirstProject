using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4//1.WAP to accept mobile number and count frequency of digit
{
    class Program1
    {
        static int frequencyDigits(long n, int d)
        {

            int count = 0;
            while (n > 0)
            {
                if (n % 10 == d)
                    count++;
                n = n / 10;
            }
            return count;
        }


        static public void Main(String[] args)
        {


            long N =777548;


            int D = 7;
            int D1 = 7;
            int D2 = 7;
            int D3 = 5;
            int D4 = 4;
            int D5 = 8;


            Console.WriteLine("Frequency of digit 7: " + frequencyDigits(N, D));
            Console.WriteLine("Frequency of digit 7: " + frequencyDigits(N, D1));
            Console.WriteLine("Frequency of digit 5: " + frequencyDigits(N, D2));
            Console.WriteLine("Frequency of digit 4: " + frequencyDigits(N, D3));
            Console.WriteLine("Frequency of digit 8: " + frequencyDigits(N, D4));
           
        }
    }
}
