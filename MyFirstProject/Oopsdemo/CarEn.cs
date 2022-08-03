using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class CarEn
    {
        int modelnum;
        string carname;
        string colour;
        long price;
        long speed;


        public int ModelNum
        {
            get { return modelnum; }
            set { modelnum = value; }
        }
        public string CarName
        {
            get { return carname; }
            set { carname = value; }

        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }

        }
        public long Price
        {
            get { return price; }
            set { price = value; }
        }
        public long Speed
        {
            get { return speed; }
            set { speed = value; }

        }
        static void Main(string[] args)
        {
            CarEn C = new CarEn();
            C.modelnum = 85;
            C.CarName = "Audi";
            C.Colour = "Black";
            C.Price = 5000000;
            C.Speed = 220;

            Console.WriteLine("Car Name=" + C.CarName);
            Console.WriteLine("Model number=" + C.modelnum);
            Console.WriteLine("Colour= " + C.Colour);
            Console.WriteLine("Price=" + C.Price);
            Console.WriteLine("Speed=" + C.Speed);




        }
    }
}
