using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Atmorphicdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int a = num;
            int sq = num * num;
            bool automorohic = true;
            
            while (num != 0)
            {
                if(num % 10!=sq % 10)
                {
                    bool automorphic = false;
                }
                num = num / 10;
                sq = sq / 10;
            }
             
        }
    }
}
