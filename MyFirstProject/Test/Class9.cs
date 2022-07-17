using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test
{
    class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Char");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
                Console.WriteLine("Special Character");
        }
    
    }
}
