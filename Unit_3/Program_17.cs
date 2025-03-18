// Program - 17 : Write a program to display maximum number from 5
// numbers inputted by user by using the concept of arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Program_13
{
    internal class Program_17
    {
        static void Main4(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Enter 5 elements for the array:");
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("The maximum number among the 5 elements is:");

            int max = num[0];

            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                } 
            }
            Console.WriteLine($"Maximum value among these is :{max}");
            Console.ReadLine();
        }
    }
}
