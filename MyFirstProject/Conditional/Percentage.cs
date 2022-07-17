using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Percentage
    {
        static void Main(string[] args)
        {
            // console.writeline("find the percentage using ladder of if else statement")

            int total,percentage;


            Console.WriteLine("Enter the Marks");
            int M1 = int.Parse(Console.ReadLine());
            int M2 = int.Parse(Console.ReadLine());
            int M3 = int.Parse(Console.ReadLine());
            int M4 = int.Parse(Console.ReadLine());
            int M5 = int.Parse(Console.ReadLine());



            total = M1 + M2 + M3 + M4 + M5;

            percentage = (total * 100) / 500;

            Console.WriteLine(percentage + "%");



            if (percentage>70)
            {
                Console.WriteLine("Distinction");

            }
            else if (percentage>60 && percentage<=70)
            {
                Console.WriteLine("First Class");
            } 
            else if (percentage > 50 && percentage <=60)
            {
                Console.WriteLine("Second Class");
            }
            else if (percentage >35 && percentage <=50)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }



        
    }

}

