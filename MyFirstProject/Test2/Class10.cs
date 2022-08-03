using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num2 = int.Parse(Console.ReadLine());

            int a = 0;
            for (int i = 2; i < num1; i++)
            {
                for(int j=2;j<num2;j++)
                {
                    if (num1 % 1 == 0 && num2 % 1 == 0)
                    {
                        a=1;
                    }

                }
                
            }
            if (a==1)
            {
                if (num1 - num2 == 2 || num2 - num1 == 2)
                {
                    Console.WriteLine("Twin prime");
                }
                else
                {
                    Console.WriteLine("Not twin prime");
                }

            }
            



        }
    }
}
