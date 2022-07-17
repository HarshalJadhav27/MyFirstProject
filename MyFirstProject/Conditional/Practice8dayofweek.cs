using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice8dayofweek
    {
        static void Main()
        {
            // TAKE INPUT A DAY OF THE WEEK & CHECK ITS A WEEKDAY OR WEEKEND.

            Console.WriteLine("Enter the day");
            string day = (Console.ReadLine());

            if (day == "Monday")
            {
                Console.WriteLine("It is a weekday");
            }
            else if(day == "Tuesday")
            {
                Console.WriteLine("It is a weekday");
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine("It is a weekday");
            }
            else if (day == "Thursday")
            {
                Console.WriteLine("It is a weekday");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("It is a weekday");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("It is a weekend");
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("It is a weekend");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}
