using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 11;
            int flag = 0;
            for(int i=2; i<num; i++)
            {
                if(num % i == 0)
                {
                    flag = 1;
                }
            }
            if (flag == 1) {
                Console.WriteLine("Not prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
            Console.ReadLine();
        }
    }
}
