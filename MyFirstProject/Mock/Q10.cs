using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Q10
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)

            {
                if (i % 2 == 0)
                {
                    int c = 1;
                    for (Char k = 'A'; c <= i; k++)           //1

                    {                                        //A B   IN TERMS OF NUMBERS
                        Console.Write(k);                   // 1 2 3 
                        c++;
                    }                                       //  A B C D
                    Console.WriteLine();

                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

    

