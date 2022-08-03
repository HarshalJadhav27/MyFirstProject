using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
           int lastdigit= n % 10;
            
          
            int sum=0;

            while (n>10)
            {
                n = n / 10;
                
               // int firstdigit = n; 

            }
            int first = n;
            sum =n + lastdigit;
            
                     
            Console.WriteLine(sum);
            
        }
    }
}
