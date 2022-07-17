using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Daylands
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("1.Monday\n2.Thusday\n3.Wednesday\n4.Thursday\n5.Friday\n6.Saturday\n7.Sunday");
                Console.WriteLine("Enter your choice");
                int Day = int.Parse(Console.ReadLine());

                switch (Day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        break;


                }
                Console.WriteLine("Do yoy want to continue");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
        }
    }
}
