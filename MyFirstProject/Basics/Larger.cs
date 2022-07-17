using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class Larger
    {
        static void Main(string[] args)
        {
            // console.writeline("Check largest number")is
            

            Console.WriteLine("Enter 1 st number");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            int num2 = int.Parse(Console.ReadLine());  //  Convert.To32(Console.ReadLine())


            if (num1 > num2)

                Console.WriteLine("The larger number is=" + num1);
            else
                Console.WriteLine("The larger number is=" + num2);






           
        }
    }
}
