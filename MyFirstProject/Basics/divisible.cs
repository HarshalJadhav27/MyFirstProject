using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class divisible
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());



            if (num % 5 == 0)
                Console.WriteLine("These number is divisible by  5");
            else
                Console.WriteLine("These number is  not divisible by  5");
        }

    }
}
