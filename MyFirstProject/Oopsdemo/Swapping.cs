using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Swapping
    {
        public void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {
            Swapping S = new Swapping();
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine("..............................");
            S.Swap(ref num1, ref num2);// pass by value
            Console.WriteLine(num1+" "+num2);

        }
    }
}
