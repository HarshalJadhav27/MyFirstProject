﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class1
    {
        static void Main(string[] args)
        {
            //WP to print all numbers between 1 and 100 ecpect the numbers which are divisible by 5 or 10

            for(int i= 1; i<=100;i++)
            {
                if(i%5==0 || i%10==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
