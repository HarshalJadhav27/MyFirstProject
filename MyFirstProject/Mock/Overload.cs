using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Mock
{
    class Overload
    {
        float Calculate_loan(int P, float R, int T)
        {
            float loan;
            return loan = (float)P * R * T;
        }
        float Calculate_loan(int P, float R1, float R2, int T)
        {
            float loan1;
            if (T <= 6)
            {
                return loan1 = (float)P * R1 * T;
            }
            else
            {
                return loan1 = (float)P * R2 * T;
            }
        }
        static void Main(string[] args)
        {
            Overload o = new Overload();
            Console.WriteLine(o.Calculate_loan(10000, 12f, 3));
            Console.WriteLine(o.Calculate_loan(10000,5f,3f,8));

        }



    }
}
