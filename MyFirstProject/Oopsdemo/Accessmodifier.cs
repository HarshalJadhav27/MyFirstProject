using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Accessmodifier:Accessdemo

    {
        static void Main(string[] args)
        {
            Accessdemo a = new Accessdemo();
          //  Console.WriteLine(a.x);
            Console.WriteLine(a.y);
           // Console.WriteLine(a.name);
            Console.WriteLine(a.z);

            Accessmodifier m = new Accessmodifier();
           // Console.WriteLine(m.x);
            Console.WriteLine(m.y);
            Console.WriteLine(m.name);
            Console.WriteLine(m.z);

        }
    }
}
