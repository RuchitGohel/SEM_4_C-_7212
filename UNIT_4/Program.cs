/*Program - 19 :Create a class “Rectangle” that would contain length and 
width as an instance variable, define constructors 
[constructor overloading (default, parameterized)]to 
initialize variables of objects. Define methods to find area 
and to display variables’
value of objects which are created

date: 10-02-2025
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_IV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Rectangle :");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width of Rectangle");
            int width = int.Parse(Console.ReadLine());

            Rectangle Rect = new Rectangle(length, width);

            Console.WriteLine(Rect.length);
            Console.WriteLine(Rect.width);
        }

        public class Rectangle
        {
            public int length;
            public int width;

            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            }
        }
    }
}
