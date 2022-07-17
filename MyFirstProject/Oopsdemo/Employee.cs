using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;


        public void AcceptDetails(int eid,string ename,int sal)
        {
            id = eid;
            name = ename;
            salary = sal;

        }
        public void Display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }


        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.AcceptDetails(1, "Harsh", 25000);
            e.Display();

            Employee e1 = new Employee();

            Console.WriteLine("Enter Id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter salary");
            int salary = int.Parse(Console.ReadLine());

            e.AcceptDetails(id, name,salary);
            e1.Display();




        }
    }
}
