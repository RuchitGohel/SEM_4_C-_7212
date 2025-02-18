using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class Named_reference
    {
        public static void Main4(string[] args)
        {
            int a = 19;
            int b = 20;
            Console.WriteLine($"Previous values {a + " " + b}");
            swap(ref a,ref b);
            Console.WriteLine($"Swapped values {a + " " + b}");
            Console.ReadLine();
        }
        static void swap(ref int a1, ref int b1)
        {
            int temp = 0;
            temp = a1;
            a1 = b1;
            b1 = temp;
        }
        
    }
}
