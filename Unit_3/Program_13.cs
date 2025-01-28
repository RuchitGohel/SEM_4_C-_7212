// Program - 13:Write a program to find minimum of three numbers using 
//conditional operator
//date - 28 - 01 -2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_11
{
    internal class Program_13
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int n3 = Convert.ToInt32(Console.ReadLine());   

            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"{n1} is the largest among these number.");
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"{n2} is the largest among these number.");
            }
            else
            {
                Console.WriteLine($"{n3} is the largest among these number.");
            }
            Console.ReadLine();
        }
    }
}
