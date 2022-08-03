using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test2
{
    class Class9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--) 
            {
                int mysteryint = 100;
                mysteryint -= i;
                Console.WriteLine(mysteryint);
            }
                
        }
    }
}
