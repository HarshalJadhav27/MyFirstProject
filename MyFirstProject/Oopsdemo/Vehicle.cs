using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Vehicle
    {
        public int Model_Num;
        public string Type;
        public int Wheels;
       // public int average;

        public void AcceptDetails(int emodel, string etype, int ewheels)
        {
            Model_Num = emodel;
            Type = etype;
            Wheels = ewheels;

        }
        public void Average()
        {
            if (Wheels == 4)
            {
                Console.WriteLine("Average is 15");
            }
            else if (Wheels == 2)
            {
                Console.WriteLine("Average is 45");
            }

        }
        public void Display()
        {
            Console.WriteLine(Model_Num+" "+Type+" "+Wheels);
        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.AcceptDetails(101,"SUV", 2);
            v.AcceptDetails(102, "Bike", 4);
            v.Display();
            v.Average();
        }
    }
}
