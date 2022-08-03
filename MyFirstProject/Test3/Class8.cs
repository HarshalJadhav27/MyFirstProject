using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Class8
    {
        static void Main(string[] args)
        {
           // 8.Write a code to check given number is Krishnamurthy number or not
                                         
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            int fact = 1;
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                for (int i = 1; i <= r; i++)
                {

                    fact = fact * i;
                    
                }
                sum = sum + fact;
                n = n / 10;
                                
            }
            n = a;

            if (n == sum)
            {
                Console.WriteLine("Krishnamurthy num");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy num");
            }




        }
    }
}
