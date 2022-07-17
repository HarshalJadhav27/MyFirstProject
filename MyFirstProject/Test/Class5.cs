using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());



            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("It is divisible by 5 or 11");

            }
            else if(num % 5 == 0)
            {
                Console.WriteLine("It is divisible by 5");

            }
            else if(num % 11 == 0)
            {
                Console.WriteLine("It is divisible by 11");
            }

            else
            {
                Console.WriteLine("It is  not divisible by 5 or 11");
            }
               
        
        }
    }
}
