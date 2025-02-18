using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class Back_Marks
    {
        public static void Main2(string[] args)
        {
            int[][] back = new int[3][];
            for(int i = 0; i < back.Length; i++)
            {
                Console.WriteLine("Enter student roll no:");
                int roll = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter no of backs:");
                int b = Convert.ToInt32(Console.ReadLine());
                back[i][0] = roll;
                back[i] = new int[i + 1];
                for(int j = 1; j <= b; j++)
                {
                    Console.WriteLine($"Enter marks for back{j}:");
                    back[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < back.Length; i++)
            {
                Console.WriteLine($"Student roll:{back[i][0]}");
                for(int j = 0; j <= back[i].Length; j++)
                {
                    Console.WriteLine($"Marks {j} : {back[i][j]}");
                }
                Console.ReadLine();
            }
        }
    }
}
