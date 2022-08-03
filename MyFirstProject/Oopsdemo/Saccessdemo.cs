using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Saccessdemo
    {
        public int rollno;
        private string name;
        internal string add;
        protected int marks;

        public void AcceptDetails(int rollno)
        {
            this.rollno = rollno;
        }
        private void AcceptDetails1(string name )
        {
            this.name = name;
        }
        internal void AcceptDetails2(string add)
        {
            this.add = add;
        }
        private void AcceptDetails3(int marks)
        {
            this.marks = marks;
        }
        static void Main(string[] args)
        {
            Saccessdemo s = new Saccessdemo();
            s.AcceptDetails(10);
            s.AcceptDetails1("Harshal");
            s.AcceptDetails2("Nahik");
            s.AcceptDetails3(90);

           /* Console.WriteLine(s.rollno);
            Console.WriteLine(s.name);
            Console.WriteLine(s.add);
            Console.WriteLine(s.marks);
*/

        }


    }
}
