﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || j == 2 && i == 2 || j == 3 && i == 3)
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
