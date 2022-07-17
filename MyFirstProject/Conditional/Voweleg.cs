using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Voweleg
    {
        static void Main()
        {
            Console.WriteLine("Enter the Char");
            char ch = Convert.ToChar(Console.ReadLine());

            /*if (ch == 'a'||ch =='A' || ch == 'e' || ch == 'E' ||ch ==  'i' || ch== 'I' ||ch==  'o' ||ch== 'O' ||ch ==  'u' ||ch ==  'U')

            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }*/


            //Ladder of if else statement

            if(ch == 'a'||ch == 'A')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
        }
        }
}
