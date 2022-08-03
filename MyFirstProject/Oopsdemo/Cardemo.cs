using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Cardemo
    {
        public string Car_name;
        public int Model_Num;
        public string Colour;
        public int Price;

        static void Main(string[] args)
        {
            Cardemo Audi = new Cardemo();
            Audi.Car_name = "Audi";
            Audi.Colour = "Black";
            Audi.Price = 700000;
            Audi.Model_Num = 101;
            Console.WriteLine(Audi.Model_Num + " " + Audi.Colour + " " + Audi.Car_name + " " + Audi.Price);


            Cardemo BMW = new Cardemo();
            BMW.Car_name = "BMW";
            BMW.Colour = "White";
            BMW.Price = 900000;
            BMW.Model_Num = 105;
            Console.WriteLine(BMW.Model_Num + " " + BMW.Colour + " " + BMW.Car_name + " " + BMW.Price);

            Cardemo I10 = new Cardemo();
            I10.Car_name = "I10";
            I10.Colour = "Black";
            I10.Price = 700000;
            I10.Model_Num = 101;
            Console.WriteLine(I10.Model_Num + " " + I10.Colour + " " + I10.Car_name + " " + I10.Price);






        }
    }
}
