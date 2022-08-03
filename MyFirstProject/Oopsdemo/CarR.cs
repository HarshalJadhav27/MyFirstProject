using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class CarR
    {
        int model_no;
        string name;
        int price;
        Engine en;

        public int Model_No
        {
            get { return model_no; }
            set { model_no = value; }

        }
        public string Name
        {
            get { return name; }
            set {name = value; }

        }
        public int Price
        {
            get { return Price; }
            set { price = value; }

        }
        public Engine En
        {
            get { return en; }
            set { en = value; }

        }
    }
    class Engine
    {
        string type;

        public string Type
        {
            get;
            set;
        }
    }
    class Carinfo
    {
        static void Main(string[] args)
        {
            CarR C = new CarR();
            C.Model_No = 567;
            C.Name = "BMW";
            C.Price = 89000;
            C.En = new Engine();
            C.En.Type = "Petrol";

            Console.WriteLine(C.Model_No+" "+C.Name+" "+C.Price+" "+C.En.Type);
        }
    }
}
