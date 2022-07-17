using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Practice4age
    {
        static void Main()
        {
            // INPUT AGE OF A PERSON AND PRINT IF HE/SHE IS TEENAGER OR NOT

            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());

            if (age >= 15 && age <= 17)
            {
                Console.WriteLine("He/She is teenager");
            }
            else
            {
                Console.WriteLine("He/She is not ateenager");
            }

        }
    }
}
