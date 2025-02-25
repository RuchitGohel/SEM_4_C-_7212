using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Values before swapping: {a + " " + b}");
            swap(ref a, ref b);
            Console.WriteLine($"Values after swapping: {a + " " + b}");
            Console.ReadLine();
        }
        public static void swap(ref int a1, ref int b1)
        {
            int temp = 0;
            temp = a1;
            a1 = b1;
            b1 = temp;
        }
    }
}
