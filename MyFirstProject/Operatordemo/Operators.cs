using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Operatordemo
{
    class Operators
    {
        static void Main()
        {
            // int a = 10;
            //a++;       //a=a+1
            //++a;
            //Console.WriteLine(a++);  //10
            //Console.WriteLine(++a);  //11

            int a = 4;
            int b = 4;


            /*int x = ++a + b++;

             Console.WriteLine(x + " " + a + " " + b);*/


            /*int x = a++ + ++b + a;
            Console.WriteLine(x + " " + a + " " + b);*/

            /*int x = --a - b-- - b - a;
            Console.WriteLine(x + " " + a + " " + b);*/

            /* int x = b++ + ++a - --a;
             Console.WriteLine(x +" "+a+" "+b);*/

            /* int x = --b - ++a + b++;
             Console.WriteLine(x + " " + a + " " + b);
 */
            int x = a-- + b - ++a - --b;
            Console.WriteLine(x + " " + a + " " + b);





        }


    }
}
