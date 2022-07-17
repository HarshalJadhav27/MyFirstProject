using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Oprator");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Addition= " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multi=" + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("division= " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
