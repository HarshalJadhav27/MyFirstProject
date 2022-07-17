using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice6age2
    {
        static void Main()
        {
            // INPUT YOUR AGE A & YOUR FRIENDS AGE:

            Console.WriteLine("Enter my age");
            int my_age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter friends age");
            int friend_age = int.Parse(Console.ReadLine());

            if (friend_age < my_age)
            {
                Console.WriteLine("Hi..");
            }
            else if (my_age < friend_age)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you?");
            }
        }
    }
}
