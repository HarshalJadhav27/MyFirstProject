using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Stardemo
    {
        static void Main(string[] args)
        {
            for (int i = 1;i<= 3; i++)
            {
                for (int j =1;j<=2;j++)
                {
                    Console.WriteLine(i +" "+ j);
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)    //square stars
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }



            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();



            }
        }
    }
}
