using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class NestedIfintro
    {
        static void Main()
        {
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the weight");
            int wt = Convert.ToInt32(Console.ReadLine());

            // first way (by using and operator)


            if (age>18 && wt>50)
            {
                Console.WriteLine("Valid for blood donation");
            }
            else
            {
                Console.WriteLine(" Not valid for blood donation");


                // second way using nested if else statement

                /*if (age > 18)
                {
                    if(wt>50)
                    {
                        Console.WriteLine("Valid for blood donation");
                    }
                    else
                    {
                        Console.WriteLine(" Person age is valid but not wt try next time...");

                    }
                }
                else
                {
                    Console.WriteLine(" Not valid for blood donation");
                }*/
            }  

        }


        
    }
}
