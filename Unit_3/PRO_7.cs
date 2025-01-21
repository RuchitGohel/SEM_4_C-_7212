// UNIT_3 #7 Write a program to input age of person and display message 
// as follows
// - If age < 12 print You are Kid
// - If age between 12 to 17 print You are teenager
// - If age between 18 to 60 print you are Adult
// If age > 60 print You are Senior Citizen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("You are a kid.");
            }
            else if (age > 12 && age <= 17)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >= 18 && age < 60) {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
            Console.ReadLine();
        }
    }
}
