using System;
using System.Collections.Generic;
using System.Text;

namespace MyFunda28_June.Loops
{
    class AdditionOfEven
    {
        static void Main(string[] args)
        {
            //print addition of even numver between 1 to 20


            int sum = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
