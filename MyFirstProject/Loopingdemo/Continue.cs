using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Continue
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.WriteLine("After Loop");
        }   
          
    }
}
