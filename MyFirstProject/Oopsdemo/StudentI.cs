using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class StudentI
    {
        int id;
        string name;
        float percentage;

        char grade;

        public void AcceptDetails(int id, string name, float percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;
        }
        public void Grade()
        {
            if (percentage > 90)
            {
                grade = 'A';
            }
            else if (percentage > 80)
            {
                grade = 'B';
            }
            else
            {
                grade = 'F';
            }
        }
        public void Display()
        {
            Console.WriteLine("student detail");
            if (percentage < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("percentage" + percentage + "grade=" + grade);
            }

            Console.WriteLine("id" + id + "name" + name + "percentage" + percentage);
        }
        static void Main(string[] args)
        {
            StudentI s = new StudentI();
            s.AcceptDetails(2, "Harsh", 80);
            s.Grade();
            s.Display();

        }


    }
}
    