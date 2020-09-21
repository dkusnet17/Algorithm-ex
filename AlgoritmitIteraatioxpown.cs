using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        private static int PowIter(double x, int n)
        {
            double result1 = 1;
            result1 = Convert.ToInt32(result);
            for (int i = 0; i < n; i++)
            {
                result1 = result1 * x; // result *= x;
            }
            return result;
        }
   
 static void Main(string[] args)
        {
            int b;
            Console.ReadLine(b);
            b = PowIter(x,n);
            Console.WriteLine(b);
        }
    }
}
