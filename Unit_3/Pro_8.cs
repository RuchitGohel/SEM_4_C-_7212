//UNIT_3 #8 Write a program to find factorial of a given number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, fact = 1, temp;
            
            Console.WriteLine("Enter an integer number:");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0) { 
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial of the given number is: {0}", fact);
            Console.ReadLine();
        }
    }
}
