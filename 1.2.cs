using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=0;
            string op;

            Console.WriteLine("Enter an integer number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer number:");
            num2 =Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter an arithmetic op:");
            op = Console.ReadLine();

            if(op == "+"){
                Console.WriteLine("The sum of the numbers is: {0}", num1 + num2);
            }
            if(op == "-"){
                Console.WriteLine("The subtraction of the numbers is: {0}", num1 - num2);
            }
            if(op == "*"){
                Console.WriteLine("The multiplication of the numbers is: {0}", num1 * num2);
            }
            if(op == "/"){
                Console.WriteLine("The division of the numbers is: {0}", num1 / num2);
            }
            else {
                Console.WriteLine("Invalid op.");
            }
            Console.ReadLine();
        }
    }
}
