using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Test
    {
        int x;

        public Test()
        {
            Console.WriteLine("Default Constructor");
        }

        public Test(string str)
        {
            Console.WriteLine("Parameter="+str);
        }
        static void Main(string[] args)
        {
            Test t = new Test();
            Console.WriteLine(t.x);
            Test t2 = new Test("Pune");


        }
    }
}
