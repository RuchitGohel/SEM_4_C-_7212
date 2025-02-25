using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Default_Parameter
    {
        public static void Main4(string[] args)
        {
            float r = 2.3f,pi=3.14f;
            AC(r,pi);
        }
        public static void AC(float r1, float pi1 = 3.14f)
        {
            Console.WriteLine("Enter radius of circle:");
            r1 = float.Parse(Console.ReadLine());
            float Area = pi1 * r1 * r1;
            Console.WriteLine($"Area of circle is: {Area}");
            Console.ReadLine();
        }
    }
}
