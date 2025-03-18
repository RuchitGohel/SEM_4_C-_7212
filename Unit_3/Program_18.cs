using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    internal class Program_18
    {
        static void Main2(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Enter 5 elements for the array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("The maximum number among the 5 elements is:");

            int min = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine($"Minimum value among these is :{min}");
            Console.ReadLine();
        }
    }
}
