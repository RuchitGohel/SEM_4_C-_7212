using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int i = 1, j = 1;
            for(i = 1; i < 6; i++)
            {
                
                for (j = 1; j <= i; j++)
                { 
                 Console.Write(k-- + " ");
                }
                k += i + j;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
