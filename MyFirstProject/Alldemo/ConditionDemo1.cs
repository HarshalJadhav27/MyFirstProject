using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunda28_June.ConditinalDemos
{
    class ConditionDemo1
    {
        //print largest number between 2 number
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number" );
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("num1 is gr  "+num1);
            }
            else
            {
                Console.WriteLine("num2 is gr  "+num2);
            }

        }
       

    }
}
