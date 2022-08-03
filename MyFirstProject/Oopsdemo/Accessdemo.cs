using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Accessdemo
    {
        private int x = 10;

        internal int y = 30;

        protected string name = "nashik";
        public int z = 89;

        static void Main(string[] args)
        {
            Accessdemo a = new Accessdemo();
            Console.WriteLine(a.x);
            Console.WriteLine(a.y);
            Console.WriteLine(a.name);
            Console.WriteLine(a.z);

        }
    }
}
