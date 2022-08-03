using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test4
{
    class Q4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                  
                }
                Console.WriteLine(" ");
            }
            
        }
    }
}
