using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Car2
    {
        string car_name;
        string modelnumber;

        public Car2():this("Bmw","Q7")
        {
            Console.WriteLine("Default car");

        }
        public Car2(string car_name, string modelnumber)
        {
            this.car_name = car_name;
            this.modelnumber = modelnumber;

        }
        public void show()
        {
            Console.WriteLine(car_name + " " + modelnumber);
        }
    }
    class ThisUse3
    { 
        static void Main(string[] args)
        {
            Car2 c = new Car2();  //("Audi","Q7");
            c.show();
            
        }
    }
}
