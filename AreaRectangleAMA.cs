using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangleAMA
{
    class Program
    {
        static void Main(string[] args)
        {

            // For this program:
            //  Ask the user for a width and a length.
            //  Then, calculate the area and perimeter of a rectangle.
            //  Display the results to the user.

            double width;
            double length;
            double area;
            double perimeter;

            Console.WriteLine("What's the width of your computer screen?");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's the length of your computer screen?");
            length = Convert.ToDouble(Console.ReadLine());

            perimeter = (2 * width) + (2 * length);

            Console.WriteLine("The perimeter of your computer screen is : ");
            Console.Write(perimeter);

            Console.WriteLine();

            area = width * length;

            Console.WriteLine("The area of your computer screen is : ");
            Console.Write(area);

            Console.ReadKey();


        }
    }
}
