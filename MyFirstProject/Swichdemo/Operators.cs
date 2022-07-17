using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swichdemo
{
    class Operators
    {
        static void Main()
        {
            Console.WriteLine("Enter 1 st number");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            int num2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter the operator");

            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)

            {
                case '+': Console.WriteLine("Addition= " + (num1 + num2));
                    break;

                case '-':Console.WriteLine("Substraction= " + (num1 - num2));
                    break;

                case '*': Console.WriteLine("Multiplication= " + (num1 * num2));
                    break;

                case '/':Console.WriteLine("Division= " + (num1 / num2));
                    break;

                default :Console.WriteLine("Invalid Operator");
                    break;
            }
             
        } 
    }
}
