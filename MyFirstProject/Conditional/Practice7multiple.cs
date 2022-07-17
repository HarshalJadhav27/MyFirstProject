using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice7multiple
    {
        static void Main()
        {
            //TAKE INPUT & CHECK IF ITS MULTIPLE OF 5

            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            if (num % 5==0)
            {
                Console.WriteLine("It is multiple of 5");

            }
            else
            {
                Console.WriteLine("It is not multiple of 5");
            }

        }
    }
}
