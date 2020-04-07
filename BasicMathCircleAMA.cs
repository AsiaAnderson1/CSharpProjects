using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCircleAMA
{
    class Program
    {
        static void Main(string[] args)
        {

            // For this program
            // Ask the user for a radius of a circle (numbers with decimals should be accepted.)
            // Calculate the area and circumference.
            //  Display the results.

            double radius;
            double area;
            double circumference;

            Console.WriteLine("Give me the radius of a circle.");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            area = radius * radius * Math.PI;
            circumference = 2 * Math.PI * radius;

            Console.WriteLine("The area of this circle is:  ");
            Console.Write(area);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The circumference of this circle is: ");
            Console.Write(circumference);

            Console.ReadKey();



        }


    }
}
