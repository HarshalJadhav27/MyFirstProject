using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class14
    {
        static void Main(string[] args)
        {
            /*int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            for(int i =0; i<n;i++)
            {
                if(i<=1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;

                }
                Console.WriteLine(c+" ");
            }
            Console.ReadLine();

*/
            int next;
            int first= 0;
            int second = 1;
            
            Console.WriteLine("Enter the range");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    next = i;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;


                }
                Console.WriteLine("\t"+next);
            }
            Console.ReadLine();
           
        }
    }
}
