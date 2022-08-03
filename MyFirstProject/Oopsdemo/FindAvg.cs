/*using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class FindAvg
    {
        double Findavg(int n)
        {
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
               if (n % i == 0)
               {
                    sum = sum + i;
                    count++;
               }
            }
            Console.WriteLine(sum + " " + count);
             double avg = sum / count;

            return avg;

        }
        static void Main(string[] args)
        {
            FindAvg F = new FindAvg();
            double ans = F.Findavg(10);
            Console.WriteLine(ans);
        }
    }
}
*/