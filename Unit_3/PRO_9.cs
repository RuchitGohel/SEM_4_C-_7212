// UNIT_3 #9 Write a program to find Fibonacci series up to a number 
// inputted by user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, num = 0, fib = 0;

            Console.WriteLine("Enter an integer number:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(a + " ");
            Console.Write(b + " ");
            
            for(int i = 0; i <= num; i++)
            {
                fib = a + b;
                Console.Write(" " +fib);
                a = b;
                b= fib;
            }
            Console.ReadLine();
        }
    }
}
