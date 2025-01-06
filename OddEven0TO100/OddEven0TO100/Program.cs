using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OddEven0TO100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int num = 0; num <= 100; num++)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even :" + num);
                }
                else
                    Console.WriteLine("Odd : " + num);
            }
            Console.ReadLine();
        }

        
    }
}
