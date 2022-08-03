using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Overloadingdemo   // overloading method.
    {
        void Show()
        {
            Console.WriteLine("Show method");
        }
        void Show(string str, int x)
        {
            Console.WriteLine(str+" "+x);
        }
        int Show(int a, int b)
        {
            return a - b;
        }
        void Show(float x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Overloadingdemo O = new Overloadingdemo();
            int a = O.Show(3, 4);
            Console.WriteLine(a);

            Console.WriteLine(O.Show(6, 4));
            O.Show();
            O.Show(34.56f);
            O.Show("Harsh", 98);

        }
    }
}
