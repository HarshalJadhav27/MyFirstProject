﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q6
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <=i ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
