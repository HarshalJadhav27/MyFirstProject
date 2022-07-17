using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swichdemo
{
    class Switchintro
    {
        static void Main()
        {
           /* case:
               break;
            case:
               break;
            case:
               break;
            default:
                break;

*/

            Console.WriteLine("Enter the character");
            Char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;

                case 'e':
                    Console.WriteLine("vowel");
                    break;

                case 'i':
                    Console.WriteLine("vowel");
                    break;

                case 'o':
                    Console.WriteLine("vowel");
                    break;

                case 'u':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("Consonant");
                    break;

                //Or

               /* case 'a':
                   

                case 'e':
                   

                case 'i':
                    
                   

                case 'o':
                    
                    

                case 'u':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("Consonent");
                    break;

*/



            }

        }
    }
}
