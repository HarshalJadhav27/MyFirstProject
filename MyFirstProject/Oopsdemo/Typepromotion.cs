using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Typepromotion
    {
        void Addition(int x, float t)
        {
            Console.WriteLine(x+t);
        }
        static void Main(string[] args)
        {
            Typepromotion T = new Typepromotion();
            //T.Addition(4,6.7);
            T.Addition(7, 5l);
        }
    }
}
