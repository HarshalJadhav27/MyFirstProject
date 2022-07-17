using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Loop1
    {
        static void Main(string[] args)
        {
            // Print addition of even number between 1 to 20  by using nested for loop

            int sum = 0;
            for(int i = 1;i<=20;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                        
                }     

            }
            Console.WriteLine(sum);
        }
    }
}
