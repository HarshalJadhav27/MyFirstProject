using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test3
{
    class Order

    {
        int order_id;
        string city;
        string name;

        public int Id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

    }
    class OrderDemo
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Id = 10;
            o.City = "Nashik";
            o.Name = "Harsh";

            Console.WriteLine(o.Name + " " + o.Id + " " + o.City);
        }
    }
}
