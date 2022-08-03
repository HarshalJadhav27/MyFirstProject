using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Static
    {
        /*int a = 10;
        int b = 10;
        double c = 7.525;
        double d = 8.358;
*/
        static int Calculator(int a, int b)
        {
            return a + b;
        }
        static float Calculator(float a, float b)
        {
            return a - b;
        }
        static double Calculator(double c, double d)
        {
            return c * d;
        }
        static double Calculator(int x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Addition " + Calculator(6, 4));
            Console.WriteLine("Substraction " + Calculator(6f, 4f));
            Console.WriteLine("Multiplication " + Calculator(25.25878, 5.5245));
            Console.WriteLine("Division " + Calculator(25, 5.25));
        }
    }
}
