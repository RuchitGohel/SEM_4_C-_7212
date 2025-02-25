using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Named_parameter
    {
        public static void Main1(string[] args)
        {
            //Console.WriteLine("Enter an integer:");
            // n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter an integer:");
            //n2 = int.Parse(Console.ReadLine());
            swap(num1: 10, num2: 20); 

        }
        public static void swap(int num1, int num2)
        {
            
             num1 += num2;
             num2 = num2 - num1;

            Console.WriteLine($"Values before swapping: {num1 + " " + num2}");

            Console.WriteLine($"Values after swapping: {num1 + " " + num2}");
            Console.ReadLine();
        }
    }
}
