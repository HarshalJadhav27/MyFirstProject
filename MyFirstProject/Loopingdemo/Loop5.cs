using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loopingdemo
{
    class Loop5
    {
        static void Main(string[] args)
        {
            /*//2,5,10,17,26.......

            for(int i = 1;i<=10;i++)
            {
                Console.WriteLine(i * i + 1 + " ");
            }*/



            /*//1,4,3,16,5,36....

            for(int i = 1;i<=10;i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);
                }
            }
*/

            //-1,4,-3,16,-5,36
            /*
                        for(int i=1;i<=10;i++)
                        {
                            if(i % 2==0)
                            {
                                Console.WriteLine(i * i);
                            }
                            else
                            {
                                Console.WriteLine(-i);
                            }
                        }*/

            //1,8,9,64,25,216

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i*i);
                }
                else
                {
                    Console.WriteLine(i * i * i);
                }
            }
            
        }
    }
}
