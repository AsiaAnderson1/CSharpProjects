using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeCheckAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display 2 numbers of your choice.
            // Have the user enter a number. 
            // Determine whether the number they entered is between the two numbers or not. 
            // Use only 1 if statement!

            int x;

            Console.WriteLine("I've picked two numbers.");
            Console.WriteLine("My numbers are: 2 and 15.");
            Console.WriteLine("Pick a number!");
            x = Convert.ToInt32(Console.ReadLine());
           
                if (x > 2 && x < 15 )
            {
                Console.WriteLine("Your number: ");
                Console.WriteLine(x);
                Console.WriteLine("is between 2 and 15.");
            }

            else
            {
                Console.WriteLine("Pick another number.");
            }

            Console.ReadKey();



        }
    }
}

