﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q8
    {
        static void Main(string[] args) // triangle
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == 5|| i==j)
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
