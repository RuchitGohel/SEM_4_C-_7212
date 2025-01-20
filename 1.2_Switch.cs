using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            string op;

            Console.WriteLine("Enter an integer:");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer:");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an arithmetic operator:);
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"The sum of the numbers is:{(num1 + num2)}");
                    break;
                case "-":
                    Console.WriteLine("The subtraction of the numbers is: {0}", num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("The multiplication of the numbers is: {0}", num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("The division of the numbers is: {0}", num1 / num2);
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
