//Unit-3.3 Write a program to input Principal Amount, Rate and Year
//and display Simple Interest
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float principal = 1.0f;
            float rate = 1.0f;
            int year = 0;

            

            Console.WriteLine("Enter principal amount:");
            principal = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate of interest:");
            rate = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the duration in years:");
            year = Convert.ToInt32(Console.ReadLine());
            float SI = (principal * rate * year) / 100;
            Console.WriteLine("The simple interest is: {0}", SI);
            Console.ReadLine();
        }
    }
}
