using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Negative
    {
        static void Main()
        {
            // console.writeline("Check  the number is positive or negative or zero using ladder of if else statement")

            Console.WriteLine("Enter the number");

            int num = int.Parse(Console.ReadLine());

            if( num > 0)
            {
                Console.WriteLine("The number is positive");

            }

            else if(num < 0)
            {
                Console.WriteLine("The number is negative");

            }

            else
            {
                Console.WriteLine("The number is zero");
            }



        }
    }
}
