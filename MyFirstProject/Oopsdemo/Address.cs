using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Address
    {
        public int pincode;
        public string city;
        
        public Address(int pincode, string city)
        {
            this.pincode = pincode;
            this.city = city;

        }
        public void ShowAddress()
        {
            Console.WriteLine(" "+pincode+" "+city);
        }

       
    }
    class Person
    {
        int id;
        string name;
        Address adr;

        Person(int id, string name, Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;

        }
        void DisplayPerson()
        {
            Console.WriteLine(id + " " + name);
            adr.ShowAddress();
        }
        static void Main(string[] args)
        {
            Address A = new Address(234,"nashik");
            Person p;
            p = new Person(2, "Harsh", A);
            p.DisplayPerson();

            

        }
    }
}
