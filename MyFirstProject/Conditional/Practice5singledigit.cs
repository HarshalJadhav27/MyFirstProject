using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice5singledigit
    {
        static void Main()
        {
            //TAKE INPUT AND COMPARE THAT NUMBER IS SINGLE DIGIT OR DOUBLE DIGIT

            Console.WriteLine("Enter the digit");
            int digit = int.Parse(Console.ReadLine());

            if (digit >= 0 && digit <= 9)
            {
                Console.WriteLine("That number is single digit");
            }
            else
            {
                Console.WriteLine("That number is double digit");
            }
        }
    }
}

