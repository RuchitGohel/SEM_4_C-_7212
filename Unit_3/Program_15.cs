// Program - 14 : Write a program to check weather a number is palindrome
// or not
// e.g. input: 121, output: It is
// palindrome input:124, output: It is
// not palindrome

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int sum = 0, rev = 0, temp = 0;
            Console.WriteLine("Enter a number to check whether it is palindrome or not.");
            int num = Convert.ToInt32(Console.ReadLine());
            //rev = num;
            while(num != 0)
            {
                temp = num % 10;
                sum = temp + (sum * 10);
                num = num / 10;  
            }
            if(rev == num)
            {
                Console.WriteLine("The number" + num + "is palindrome.");
            }
            else
            {
                Console.WriteLine("It is not a palindrome number.");
            }
            Console.ReadLine();
        }
    }
}
