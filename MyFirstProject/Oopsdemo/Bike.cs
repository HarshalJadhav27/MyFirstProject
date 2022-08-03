using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Bike
    {
        string Bike_name;
        string modelnumber;
        long price;
        String Colour;

        public Bike():this("Bajaj","M3",89000,"Black")                 // third use
        {
            Console.WriteLine("Excellent Bike");

        }
        public Bike(string Bike_name, string modelnumber,long price,string Colour)
        {
            this.Bike_name = Bike_name;                    // first use
            this.modelnumber = modelnumber;
            this.price = price;
            this.Colour = Colour;
            this.show();                                   // second use
        }
        public void show()
        {
            Console.WriteLine(Bike_name + " " + modelnumber+" "+price+" "+Colour);
        }
    }
    class This123
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
           // Bike b1 = new Bike("Bajaj", "Q7", 89500, "Black");
        }
    }
}
