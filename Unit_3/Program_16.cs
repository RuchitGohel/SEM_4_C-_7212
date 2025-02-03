// Program - 16 : Write a program to check weather a number is ArmStrong or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    internal class Program_16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check whether it is armstrong or not.");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = 0, m = 0, arm = 0;
            arm = num;

            while(num != 0)
            {
                m = num % 10;
                temp = temp + (m * m * m);
                num = num / 10;
            }
            if (arm == temp)
            {
                Console.WriteLine("It is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("It is not an Armstrong number.");
            }
            Console.ReadLine();
        }
    
    }
    }

