using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class OverloadingCalculator
    {
        int Calculator(int a, int b)
        {
            return a + b;
        }
        float Calculator(float a, float b)
        {
            return a - b;
        }
        double Calculator(double c, double d)
        {
            return c * d;
        }
        double Calculator(int x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            OverloadingCalculator O = new OverloadingCalculator();
            Console.WriteLine("Addition " + O.Calculator(6, 4));
            Console.WriteLine("Substraction " + O.Calculator(6f, 4f));
            Console.WriteLine("Multiplication " + O.Calculator(25.25878, 5.5245));
            Console.WriteLine("Division " + O.Calculator(25, 5.25));

        }
    }
}
