// UNIT_3 #6 Write a program to input a number and print whether it is 
// Even or Odd Number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Enter an integer number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("It is an even number.");
            }
            else
            {
                Console.WriteLine("It is an odd number.");
            }
            Console.ReadLine();
        }
    }
}
