// Program - 12 : Write a program to Calculate sum of the number inputted by 
// the user for
// e.g. if user has inputted 1234 then it’s sum is 10
// date - 28- 01- 2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_11
{
    internal class Program_12
    {
        static void Main2(string[] args)
        {
            int num = 0, sum = 0;

            Console.WriteLine("Enter a number to know the sum of its digits:");
            num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine("The sum of the number is:" + sum);
            Console.ReadLine();
        }
    }
}
