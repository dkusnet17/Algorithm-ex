using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp102
{
    class Program
    {
        private static double PowIter(double x, int n)
        {
            double result = 1;
            for (double i = 0; i < n; i++)
            {
                result = result * x; 
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            // Starting the timer
            timer.Start();
            double b = PowIter(2, 7);
            Console.WriteLine(b);
            timer.Stop();
            Console.WriteLine("The operation took {0}ms",
            timer.ElapsedMilliseconds);
        }

    }
}
