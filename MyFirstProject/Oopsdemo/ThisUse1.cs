using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class ThisUse1
    {
        int x = 10;
         public void input(int x)
        {
            this.x = x;
        }

        public void show()
        {
            Console.WriteLine("x="+x);
        }

        static void Main(string[] args)
        {
            ThisUse1 t = new ThisUse1();
            t.input(120);
            t.show();

        }
    }
}
