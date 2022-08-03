using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Department
    {
        public int id;
        public string name;

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public void Show()
        {
            Console.WriteLine(" "+id+" "+name);
        }

    }
    class Emplployee
    {
        int id;
        string name;
        int salary;
        Department dept;

        public void Employee(int id, string name, int salary, Department dept)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.dept = dept;

        }
        void Display()
        {
            Console.WriteLine(" "+id+" "+name+" "+salary+" "+dept);
            dept.Show();

        }
        static void Main(string[] args)
        {
                
        }
    }
}
