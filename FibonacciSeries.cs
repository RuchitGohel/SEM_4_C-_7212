
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3 = 0;
            Console.Write(f1 + " ");
            Console.Write(f2 + " ");
            //
            //Console.Write(f1 + f2 + " ");
            for (int i = 0; i < 10; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;
            }
            Console.ReadLine();
        }
    }
}
