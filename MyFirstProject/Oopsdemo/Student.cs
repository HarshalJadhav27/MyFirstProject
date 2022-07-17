using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Student
    {
        public int id;
        public string name;
        public double marks;

        static void Main(string[] args)
        {
            Student s = new Student();

            s.id = 101;
            s.name = "Harshal";
            s.marks = 79.20;

            Console.WriteLine(s.id+" "+s.name+" "+s.marks);
        }
    }
}
