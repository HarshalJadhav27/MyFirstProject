using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice1greter
    {
        static void Main()
        {
            // console.writeline("Check number is > 5 or not")

            Console.WriteLine("Enter the number");

            int num = int.Parse(Console.ReadLine());

            if (num > 5)
            {
                Console.WriteLine("The number is greater than 5");
            }
            else
            {
                Console.WriteLine("The number is not greater than 5");
            }

                
           
                
        }
    }
}
