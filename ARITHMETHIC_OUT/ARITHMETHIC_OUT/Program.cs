using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARITHMETHIC_OUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 3;
            int sum, sub, mul, div;

            Cal(a, b, out sum, out sub, out mul, out div);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Subtraction: {sub}");
            Console.WriteLine($"Multiplication: {mul}");
            Console.WriteLine($"Division: {div}");
            Console.ReadLine();
        }
        public static void Cal(int a, int b, out int sum, out int sub, out int mul, out int div)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }
    }
}
