using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Loop9h
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of table");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, (num * i));
;
            }
        }
    }
}
