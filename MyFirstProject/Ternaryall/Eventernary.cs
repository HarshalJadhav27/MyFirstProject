using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Ternaryall
{
    class Eventernary
    {
        static void Main()
        {
            // console.writeline("Check the number is evev or odd by using ternary operator")is



            /* Conditional ? true part:false part
              int result = num1 > num2 ? num1 : num2;
 */

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());



            if (num % 2 == 0)
                Console.WriteLine("The number is even");


            else
                Console.WriteLine("The number is odd");

            string ans = num % 2 == 0 ? "The Number is even" : "The Number is odd";
            Console.WriteLine(ans);





        }
    }
}
