using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class OverloadingMobile   //overloading constructor.
    {
        int price;
        string name;
        string memory;

        public OverloadingMobile()
        {
            Console.WriteLine("I am default");
        }
        public OverloadingMobile(string name)
        {
            this.name= name;
        }
        public OverloadingMobile(int price, string memory)
        {
            this.price = price;
            this.memory = memory;
        }

    }
    class ConstructorOverload
    {
        static void Main(string[] args)
        {
            OverloadingMobile M = new OverloadingMobile();
            OverloadingMobile M1 = new OverloadingMobile("MI");
            OverloadingMobile M2 = new OverloadingMobile(17500, "128GB");
        }

    }
}
