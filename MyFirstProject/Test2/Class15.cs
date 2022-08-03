using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last series");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            float sum = 0;
            float term;

            for (int i = 1; i <= num; i++)

            {
                fact *= i;
                term = 1 / fact;
                sum += fact;
                               
            }
            Console.WriteLine(""+sum);
        }
    }
}
