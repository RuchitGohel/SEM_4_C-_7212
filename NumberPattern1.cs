using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 0; i<6;i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(k++ + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
