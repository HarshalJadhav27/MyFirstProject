using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q7
    {
        static void Main(string[] args)//square with spaces
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || i == 1 || i == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
