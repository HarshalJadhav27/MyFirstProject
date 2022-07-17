using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks");
            int S1 = int.Parse(Console.ReadLine());
            int S2 = int.Parse(Console.ReadLine());
            int S3 = int.Parse(Console.ReadLine());
            int S4 = int.Parse(Console.ReadLine()); 
            int S5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of subjects");
            int subjects = int.Parse(Console.ReadLine());

            int total_marks      = S1 + S2 + S3 + S4 + S5;
            int average          =(total_marks / subjects);
            int percentage       =(total_marks * 100) / 500;

            Console.WriteLine("Total =  "+ total_marks);
            Console.WriteLine("Average = "+average);

            Console.WriteLine("Percentage = "+percentage+"%");


        }
    }
}
