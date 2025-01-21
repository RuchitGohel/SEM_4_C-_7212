// UNIT_3 #10 Write a program to check weather a number inputted by 
// user is prime or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Enter an integer to check whether it is prime number.");
            num = Convert.ToInt32(Console.ReadLine());

            int flag = 0;

            for(int i = 0; i < num; i++) { 
                if (num % 2 == 0)
                {
                flag = 1;
                break;
                }
            }
            if (flag == 1) {
                Console.WriteLine("It is not a Prime number.");
            }
            else {
                Console.WriteLine("It is a prime number.");
            }
            Console.ReadLine();
        }
    }
}
