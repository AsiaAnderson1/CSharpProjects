using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuttHikeAMA
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Print all of the numbers between 0 and 100, with a couple of exceptions.
               If the number is a multiple of 3, instead of printing the number, print: hutt
               If the number is a multiple of 7, instead of printing the number, print: hike
            */

            for (int x =0; x <= 100; x++)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("Hutt");
                }


                if (x % 7 == 0)
                    {
                        Console.WriteLine("Hike");
                    }
               
                if (x % 3 != 0 && x % 7 != 0)
                {
                    Console.WriteLine(x);
                }

                Console.ReadKey();
            }

             /* I knew I needed a loop to print numbers up to 100.
                I knew I could use modulo to determine whether something was a multiple of 3/7 or an exception.
                Using a for loop to change each number that is a multiple
                Initially, multiples of 3 were printing hutt and itself. I had 2 if statements.
                and an else statement. 
             */




        }
    }
}
