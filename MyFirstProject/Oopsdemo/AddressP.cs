using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class AddressPC
    {
        int pincodea;
        string citya;

        public int Pincode
        {
            get { return pincodea; }
            set { pincodea = value; }
        }
        public string City
        {
            get { return citya; }
            set { citya = value; }
        }
    }
    class PersonP
    {
        int ida;
        string namea;
        Address adra;

        public int Id
        {
            get { return ida; }
            set { ida = value; }

        }
        public string Name
        {
            get { return namea; }
            set { namea= value; }
        }
        public Address Adr
        {
            get { return adra; }
            set { adra= value; }
        }
    }
    class Addressinfo
    {
        static void Main(string[] args)
        {
            PersonP p = new PersonP();
            p.Id = 101;
            p.Name = "Harsh";
            p.Adr = new AddressPC();
            p.Adr.pincode = 42;

            p.Adr.city = "Nashik";

            Console.WriteLine(p.Id + " " + p.Name + " " + p.Adr.city + " " + p.Adr.pincode);



        }
    }
}
