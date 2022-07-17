using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swichdemo
{
    class Operatordemo1
    {
        static void Main()
        {
            Console.WriteLine("Enter 1 st number");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter Your Choice");
            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)

            {
                case 1:
                    Console.WriteLine("Addition= " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Substraction= " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Multiplication= " + (num1 * num2));
                    break;

                case 4:
                    Console.WriteLine("Division= " + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
