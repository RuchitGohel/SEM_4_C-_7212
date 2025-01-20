//Write a program to input Principal Amount, Rate and Year
//and display Compound Interest
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, r, n;
            double ci;

            Console.WriteLine("Enter principal amount:");
            p = double.Parse(Console.ReadLine());   

            Console.WriteLine("Enter rate of interest:");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter duration in years:");
            n = double.Parse(Console.ReadLine());

            ci = (p * Math.Pow(1 + r / 100, n) - p);

            Console.WriteLine($"Compound interest is:{ci}");
            Console.ReadLine();
        }
    }
}
