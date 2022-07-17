using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 st number");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            int num2 = int.Parse(Console.ReadLine());  //  Convert.To32(Console.ReadLine())

            Console.WriteLine("Enter 3 rd number");

            int num3 = int.Parse(Console.ReadLine());


            string result = num1 > num2 && num1 > num3 ? "num1 is greater" : num2 > num3 && num2 > num1 ? "num2 is greater" : "num3 is greater";
            Console.WriteLine(result);
        }
    
    }
}
