using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Params
    {
        public static void Main(string[] args)
        {
            Mul(10, 20, 30);
        }
        public static void Mul(params int[] a)
        {
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
