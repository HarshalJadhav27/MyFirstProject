using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class ThisUse2
    {
        public void input()
        {
            Console.WriteLine("Input method");
            this.show();

        }

        public void show()
        {
            Console.WriteLine("show method");
        }

        static void Main(string[] args)
        {
            ThisUse2 t = new ThisUse2();
            t.input();
           // t.show();

        }
    }
}
