using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Armstrongdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
           int  a = num; 
            int result = 0;
           while(num!=0)
           {
                int r = num % 10;
                int cube = r * r * r;
                result = result + cube;
                num = num / 10;

           }
           num=a;
           if(num==result)
           {
                Console.WriteLine("Armstrong num    "+ result);
           }
           else
           {
                Console.WriteLine(" Not Armstrong num   "+ result);
           }
            
        }
    }
}
