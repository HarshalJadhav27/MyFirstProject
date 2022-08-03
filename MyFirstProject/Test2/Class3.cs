using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class3
    {
        static void Main(string[] args)
        {
            int i = 1;int K = 1;
            while(i++<=5)
            {
                K *= i;
            }
            Console.WriteLine("k="+K+"i="+i);
        }
    }
}
