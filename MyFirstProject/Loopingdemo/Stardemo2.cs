using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Stardemo2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////////////////////////////////////////");

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////");


            for (int i=1;i<=4;i++)
            {
                for(int k= 1;k<=4;k++)
                {
                    Console.Write(" ");
                }
                for(int j=4;j>=i;j--)          //Reverse triangle
                {
                    Console.Write("  * ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    Console.Write("");
                }
                for (int j = 4; j >= i; j--)      //4321
                                                    //432
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////");


            for (char i = 'A'; i <= 'D'; i++)
            {
                for (Char k = 'A'; k <=i; k++)           //A 
                {                                        //A B     IN TERMS OF NUMBERS
                    Console.Write(k);                   // A B C
                }                                       // A B C D
                Console.WriteLine();
               
            }


            Console.WriteLine("//////////////////////////////////////////////////////////////");

            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char k = 'A'; k <= i; k++)           //A B C D
                {                                        //A B C    IN TERMS OF NUMBERS   ERROR
                    Console.Write(k);                   // A B 
                }                                       // A 
                Console.WriteLine();

            }
            Console.WriteLine("////////////////////////////////////////////////////////////////");


            for (int i = 1; i <= 4; i++)

            {
                if(i % 2 != 0)
                {
                    int c = 1;
                    for (Char k = 'A'; c<= i; k++)           //A 
                    {                                        //1 2     IN TERMS OF NUMBERS
                        Console.Write(k);                   // A B C
                        c++;
                    }                                       // 1 2 3 4
                    Console.WriteLine();

                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                    Console.WriteLine( );
                }

            }

        }
    }
}
