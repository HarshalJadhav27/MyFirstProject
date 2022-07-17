using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class Even_or_Odd
    {
      static void Main(string[] args)
      {
            // console.writeline("Check the number is evev or odd")is

            
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            

            if (num % 2 == 0)
                 Console.WriteLine("The number is even");


            else
                Console.WriteLine("The number is odd");

      }
    }
}
