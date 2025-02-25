using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Out_Parameter
    {
        static void Main3(string[] args)
        {
            int a1 = 400;
            int b1 = 230;
            Console.WriteLine($"Values before swapping: {a1 + " " + b1}");

            swap(out a1, out b1, a1, b1);

            Console.WriteLine($"Values after swapping: {a1 + " " + b1}");
            Console.ReadLine();
        }
        public static void swap(out int a1, out int b1, int A1, int B1)
        {
            a1 = A1;
            b1 = B1;

            int temp = 0;
            temp = a1;
            a1 = b1;
            b1 = temp;
        }
    }
}
