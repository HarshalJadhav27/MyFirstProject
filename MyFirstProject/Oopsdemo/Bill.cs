using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Bill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the purchase item");
            string I = Console.ReadLine();
            Console.WriteLine( "Enter the quantity");
            int Q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the prize");
            int P = int.Parse(Console.ReadLine());

            int Total_bill = Q * P; 
            if(Q<=0)
            {
                Console.WriteLine("Error");
            }
            else
                Console.WriteLine(Total_bill);
        }
    }
}
