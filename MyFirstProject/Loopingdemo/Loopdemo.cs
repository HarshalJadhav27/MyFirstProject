using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Loopdemo
    {
        static void Main(string[] args)
        {
            // For Loop Syntax 

            /* for(initilization;Conditional;increment/decrement)
             {
                 Logic
             }*/


            // Simple for loop

            /*int i;
            for(i=1;i<=5;i++)
            {
                Console.WriteLine("Hello");
            }*/


            //Ex: If print i value or 1 to 5 numbers


            /*for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }*/


            //Ex: If print i value or 5 to 1 numbers(reverse order)

            /* int i = 5;
             for( ;i>=1;i--)     // or  for(int i=5;i>=1;i--) take i value inside or outside depend upon user
             {
                 Console.WriteLine(i);
             }*/


            /*for(int i=1;i>=5;i++)
            {
                Console.WriteLine(i);
            }*/



            /*  // Infinite Loop because there is NO CONDITION

              for(int i = 1; ;i++)
              {
                  Console.WriteLine(i);
              }
  */

            /*// Multiple times i value present at output because there is no increment/decrement


            for (int i = 1; i <= 5;)
            {
                Console.WriteLine(i);
            }*/



            /*// print multiple times because there is no condition or updation


            for( ; ; )
            {
                Console.WriteLine("hii");
            }*/






        }

    }
}
