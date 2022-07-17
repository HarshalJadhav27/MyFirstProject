using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Studentm
    {
        public int id;
        public string name;
        public int m1;
        public int m2;
        public int m3;
        public int total;
        public int percentage;



        public void AcceptDetails(int eid,string nam,int em1 ,int em2 ,int em3)
        {
            id = eid;
            name = nam;
            m1=  em1;
            m2 = em2;
            m3 = em3;

        }


        public void Calculate()
        {
            total = m1 + m2 + m3;
            percentage = (total * 100) / 300;
        }

        public void Display()
        {
            Console.WriteLine(id+" "+name+""+m1+m2+m3);
            Console.WriteLine("Total="+total+" "+"percentage="+percentage+"%");
        }


        static void Main(string[] args)
        {
            Studentm s = new Studentm();
            s.AcceptDetails(201, "Harsh", 95, 90  , 85);
            s.Calculate();
            s.Display();
        }
    }
}
