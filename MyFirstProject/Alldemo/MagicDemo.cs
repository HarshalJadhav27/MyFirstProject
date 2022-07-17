using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunda28_June.Loops
{
    class MagicDemo
    {
        static void Main(string[] args)
        {
            int magic_Number = 56;

            while(true)
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                if(num>magic_Number)
                {
                    Console.WriteLine("Number is greater than magic pls try again.....");
                    continue;
                }
                else if(num<magic_Number)
                {
                    Console.WriteLine("Numbr is less than magic pls try again......");
                    continue;
                }
                else
                {
                    Console.WriteLine("You guess Correct ...........");
                    break;
                }
            }
        }
    }
}
