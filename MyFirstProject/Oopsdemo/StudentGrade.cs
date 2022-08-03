using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class StudentGrade
    {
        int id;
        string name;
        int Percentage;
        int m1;
        int m2;
        int m3;
        int total;
        char grade;



        public void AcceptDetails(int id, string name, int m1, int m2, int m3)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;

            if (this.Percentage <= 0)
            {
                Console.WriteLine("Error");
            }
            else if(this.Percentage>70)
            {
                Console.WriteLine("Grade A");
            }
            else
            {
                Console.WriteLine("Fail");
                this.Display();
            }


        }
        public int Calculate()
        {
            total = m1 + m2 + m3;
            Percentage = (total * 100) / 300;
            return Percentage;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + "" + m1 + m2 + m3);
            Console.WriteLine("Total=" + total + " " + "percentage=" + Percentage + "%");
        }
        static void Main(string[] args)
        {
            Studentm s = new Studentm();
            s.AcceptDetails(201, "Harsh", 95, 90, 85);
            s.Calculate();
            s.Display();
        }


    }
        
}
