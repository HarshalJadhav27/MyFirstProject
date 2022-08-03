using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class6
    {
        static void Main(string[] args)
        {/*
            6.Write a program to print number from 1 to 100 such that when a number \n
                is factor of 3 and 5 both print  “RedBlue”  and if given number is /n
                    factor of only 3 the print “red” and if given number is \n
                factor of only 5 then “blue” otherwise the number itself*/

           
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Red Blue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
