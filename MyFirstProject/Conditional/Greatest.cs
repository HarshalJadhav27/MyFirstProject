using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Greatest
    {
        static void Main()
        {
            // console.writeline("Check greatest number using nested if else statement")is

            
            Console.WriteLine("Enter 1 st number");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            int num2 = int.Parse(Console.ReadLine());  //  Convert.To32(Console.ReadLine())

            Console.WriteLine("Enter 3 rd number");

            int num3 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The larger number is=" + num1);
                }
                else
                {
                    Console.WriteLine("The larger number is=" + num3);
                }
            }

            else if (num2 > num3)
            {
                if (num2 > num1)
                {

                    Console.WriteLine("The larger number is=" + num2);
                }



                else
                {
                    Console.WriteLine("The larger number is=" + num3);

                }
            }

                       
        }
    }
}
