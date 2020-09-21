using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
        private static int PowIter(int v1, int v2)
        {
            int result = 1;
            for (int i = 0; i < v2; i++)
            {
                result = result * v1; // result *= v1;
            }
            return result;
        }
   
 static void Main(string[] args)
        {
            int b = PowIter(2, 6);
            Console.WriteLine(b);
        }
    }
}
