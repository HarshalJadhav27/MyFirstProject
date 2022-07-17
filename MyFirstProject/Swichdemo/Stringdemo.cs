using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swichdemo
{
    class Stringdemo
    {
        static void Main()
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();

            switch(str)
            {
                case "happy": Console.WriteLine("Happy");
                    break;

                case "new": Console.WriteLine("new");
                    break;

                case "year": Console.WriteLine("year");
                    break;

                default: Console.WriteLine("welcome");
                    break;


            }
        }
    }
}
