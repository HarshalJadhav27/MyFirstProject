using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n= int.Parse(Console.ReadLine());

            for(int i=1;i<=4;i++)
            {
                for(int k=5;k>=i;k--)
                {                                               
                    Console.Write(" ");                           
                }                                                   
                for( int j=1;j<=n;j++)
                {
                    Console.Write(i);
                }
                n = n + 2;
                Console.WriteLine();
            }
        }
    }
}
