using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Ternaryall
{
    class Positiveternary
    {
        static void Main()
        {
            // console.writeline("Check  the number is positive or negative or zero using Ternary Operator")

            Console.WriteLine("Enter the number");

            int num = int.Parse(Console.ReadLine());

            //   string result = num >0 ? "The number is Positive" : "The number is negative";

            string result = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";

            Console.WriteLine(result);


        }
    }
}
