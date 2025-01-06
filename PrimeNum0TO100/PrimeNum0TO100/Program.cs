using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum0TO100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++)
            {
                int flag = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                 Console.WriteLine(num);
            }
            Console.ReadLine();
        }
            
        }
    }
