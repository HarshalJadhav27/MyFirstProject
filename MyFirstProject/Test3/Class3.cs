using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class3
    {
        static void Main(string[] args)
        {
            /*            3. WAP to print number from 1 to 50 if number is even \n
                            then print as it is and number is odd then print its square*/

           // Console.WriteLine("Enter the number");
           // int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd num="+ i*i);
                }
                else
                {
                    Console.WriteLine("even num="+ i);
                }
            }
        }
    }
}
