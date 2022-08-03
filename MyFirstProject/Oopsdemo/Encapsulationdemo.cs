using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Encapsulationdemo
    {
        int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Name
        {
            get { return name; }
            set { name=value;}
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }

        }

        static void Main(string[] args)
        {
            Encapsulationdemo e = new Encapsulationdemo();
            e.Id = 11;
            e.Name = "Harshal";
            e.Salary = 20000;

            int eid = e.Id;
            Console.WriteLine(e.id);

            Console.WriteLine(e.Name+" "+ e.Salary);



        }
    }
}
