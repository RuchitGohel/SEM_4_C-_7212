//UNIT_3 #5 Write a program to input radius of a circle, and print area of 
//that circle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radius = 1.0f;
            double ac = 3.14 * radius * radius;

            Console.WriteLine("Enter radius for circle:");
            radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Area of circle is: {0}", ac);
            Console.ReadLine();
        }
    }
}
