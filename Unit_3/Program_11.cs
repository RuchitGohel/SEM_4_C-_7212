//11. Write a program to find all prime numbers between two 
//values inputted by the user
// Date : 27/01/2025

using System;
using System.Data.SqlTypes;

namespace Program_11
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int n1 = 0, n2 = 0, flag = 0;

            Console.WriteLine("Enter starting range:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending range:");
            n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++){
                flag = 0;
                for (int j = 2; j <= i / 2; j++){
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }   
                }
                if (flag == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

