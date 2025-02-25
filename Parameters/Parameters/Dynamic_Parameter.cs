using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Dynamic_Parameter
    {
        public static void Main5(string[] args)
        {
            Add(30);
        }
        public static void Add(dynamic value)
        {
            value *= value;
            Console.WriteLine(value);
        }
    }
}
