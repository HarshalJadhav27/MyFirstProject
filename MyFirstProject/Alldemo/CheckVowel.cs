using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunda28_June.ConditinalDemos
{
    class CheckVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'u' || ch == 'o' || ch == 'E' || ch == 'A')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }


           /* if(ch=='a')
            {
                Console.WriteLine("vowel");
            }
            else if(ch=='i')
            {
                Console.WriteLine("vowel");
            }
            else if(ch=='e')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='o')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }*/
        }
    }
}
