using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp100
{
    class Program
    {
            private static void AscRec(int n)
            {
                if (n < 1)
                { // base-case
                    Console.WriteLine();
                }
                else
                {
                    AscRec(n - 1);
                    Console.Write(n + " ");
                }
            }
            static void Main(string[] args)
            {
                AscRec(5);
                // tulostaa isoimmasta pienimpään (n -> 1)
            }
    }
}
