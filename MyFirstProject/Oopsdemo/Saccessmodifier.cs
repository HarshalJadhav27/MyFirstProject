using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Saccessmodifier : Saccessdemo
    {
        static void Main(string[] args)
        {
            Saccessdemo s = new Saccessdemo();
            Console.WriteLine(s.rollno);
            Console.WriteLine(s.add);


            Saccessmodifier s1 = new Saccessmodifier();
            Console.WriteLine(s1.marks);


        }
    }
}
