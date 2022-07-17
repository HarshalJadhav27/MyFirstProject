using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice3compare
    {
        static void Main()
        {
            // INPUT TWO NUMBERS AND COMPARE THEM BY USING (>,<,==,<=,>=,!= OPERATORS)

            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("num2 is greater");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Both are same");
            }
            else if (num1 <= num2)
            {
                Console.WriteLine("num2 is greater or equal");
            }
            else if (num1 >= num2)
            {
                Console.WriteLine("num1 is greater or equal");
            }
            else if (num1 != num2)
            {
                Console.WriteLine("num1 is not equal to num2");
            }

        }
    }
}
