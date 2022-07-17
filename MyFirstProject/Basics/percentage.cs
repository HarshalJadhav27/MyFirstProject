using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class percentage
    {
        static void Main()
        {
            // console.writeline("find the percentage")

             int  total, result;


            Console.WriteLine("Enter the Marks");
            int M1 = int.Parse(Console.ReadLine());
            int M2 = int.Parse(Console.ReadLine());
            int M3 = int.Parse(Console.ReadLine());
            int M4 = int.Parse(Console.ReadLine());
            int M5 = int.Parse(Console.ReadLine());

                     

            total = M1 + M2 + M3 + M4 + M5;

            result = (total * 100) / 500;

            Console.WriteLine(result + "%");

        }
    }
}
