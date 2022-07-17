using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Disariumnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int a = num;
            int count = 0;

            while(num!=0)
            {
                count++;
                num = num / 10;
            }
            num = a;
            Console.WriteLine(count);
            int Sum = 0;
            while(num!=0)
            {
                int r = num % 10;
                int power = 1;
                for(int i =1;i<=count;i++)
                {
                    power = power * r;
                }

                Sum = Sum + power;
                count--;

                num = num / 10;


            }
            Console.WriteLine("sum"+ Sum);
            num = a;
            if(num ==Sum)
            {
                Console.WriteLine("Number is Disarium");
            }
            else
            {
                Console.WriteLine("not Disarium");
            }
                    

        }
    }
}
