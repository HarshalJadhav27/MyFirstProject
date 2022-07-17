using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Inputdemo
    {
        static void Main()
        {

            Console.WriteLine("Enter the city name");

            string city = Console.ReadLine();

            Console.WriteLine("City Name=" + city);



            Console.WriteLine("Enter the number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + "   " + (num + 2));

            float per = float.Parse(Console.ReadLine());
            Console.WriteLine("per=" + per);

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);


            char ch = Convert.ToChar(Console.ReadLine());  // always use for convert
            Console.WriteLine(ch);














        }
    }
}
