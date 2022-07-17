using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Ternaryall
{
    class Greater
    {
        static void Main()
        {
            // console.writeline("Check greatest number using ternary operator")

            //string result = num1 > num2 && num1 > num3 ? "num1 is greater"\n   (IF TWO CONDITION ARE PRESENT)
            //: num2 > num3 && num2 > num1 ? "num2 is greater" : "num3 is greater";

            //variable = condition?True Part:condition?True Part:False Part



            
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
