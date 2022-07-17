using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.demoOops
{
    class Methoddemo
    {

        // accessModifier returntype methodname()
        // {
        //   logic
        // }

        // no return type no parameter     

        public void show() // method defination or method body
        {
            Console.WriteLine("Show method");
        }


        // no return type with parameter

        public void Addition(int x,float y)
        {
            float result = x + y;
            Console.WriteLine("Result="+ result);
        }

        // with return type no parameter

        public int AreaRectangle()
        {
            int a = 5 * 4;
            return a;
        }

        //with return type with parameter

        public float Areaofcircle(int r)
        {
            float PI = 3.14f;

            return (PI * r * r);

        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Methoddemo d = new Methoddemo();
            d.show();                           //method calling

            d.Addition(5, 8.9f);

           int myarea=  d.AreaRectangle();
            Console.WriteLine("Area of recrangle= "+myarea);

            float circle = d.Areaofcircle(4);
            Console.WriteLine("Area of circle="+ circle);

        }
    }
}
