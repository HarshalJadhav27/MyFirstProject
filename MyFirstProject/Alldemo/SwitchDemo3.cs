using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunda28_June.ConditinalDemos
{
    class SwitchDemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            switch(str)
            {
                case "happy": Console.WriteLine("Happy");

                    break;
                case "new": Console.WriteLine("New");
                    break;
                case "year": Console.WriteLine("Year");
                    break;
                default: Console.WriteLine("Welcome");
                    break;
            }
        }
    }
}
