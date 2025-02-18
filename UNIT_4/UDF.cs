using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_4
{
    internal class UDF
    {
        public static void Main5(string[] args)
        {
            int[] a = { 11, 22, 55, 77, 3, 6, 9, 24, 90, 100};
            Console.WriteLine("Before sorting:");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            sort(ref a);
           
            Console.WriteLine($"After sorting");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
        static void sort(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                        if (a[i] >= a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }         
                }
            }
        }
    }

