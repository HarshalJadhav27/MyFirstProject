using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Animal
    {
        public string Name;
        public int Legs;
        public string Foodtype;

        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.Name = "Lucky";
            Dog.Legs = 4;
            Dog.Foodtype = "Dry food";
            Console.WriteLine(Dog.Name+" "+Dog.Legs+" "+Dog.Foodtype);

            Animal Lion = new Animal();
            Lion.Name = "Simba";
            Lion.Legs = 4;
            Lion.Foodtype ="Eat meat";
            Console.WriteLine(Lion.Name + " " +Lion.Legs + " " + Lion.Foodtype);


        }

    }
}
