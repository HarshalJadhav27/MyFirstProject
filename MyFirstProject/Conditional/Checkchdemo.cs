using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Checkchdemo
    {
        static void Main()

            // Check alphabet,digit and special symbol
        {
            Console.WriteLine("Enter the Char");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' || ch <= 'z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= 'A' || ch <= 'Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= '0' || ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
                Console.WriteLine("Special Character");
        }
    }
}
