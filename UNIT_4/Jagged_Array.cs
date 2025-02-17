using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class Jagged_Array
    {
        static void Main(string[] args)
        {
            string[][] jag = new string[5][];
            
            for(int i = 0; i < jag.Length; i++)
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();   
                Console.WriteLine("Enter no of books:");
                int n = Convert.ToInt32(Console.ReadLine());
                jag[i] = new string[n + 1];
                jag[i][0] = name;
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine("Enter book's name:");
                    jag[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < jag.Length; i++)
            {
                Console.WriteLine($"Student name: {jag[i][0]}");
                for(int j = 1; j <= jag[i].Length; j++)
                {
                    Console.WriteLine($"Book {j} = {jag[i][j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
