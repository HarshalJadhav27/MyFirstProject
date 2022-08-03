using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            int a = 1;
            while(n!=0)
            {
                if(n%10!=cube%10)
                {
                    a = 0;

                }
                n = n / 10;
                cube = cube / 10;

            }
            if(a==1)
            {
                Console.WriteLine("Triomorphic");
            }
            else
            {
                Console.WriteLine("Not Triomorphic");
            }
        }
    }
}
