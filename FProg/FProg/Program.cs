using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            if (a % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            Console.ReadLine();
        }
    }
}

