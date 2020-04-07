using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceArrayAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The program is going to throw two 6 sided dice.xx
                Ask the user how many times the dice should be thrown.xx
                Calculate the total of each dice throw.xx
                Keep a record of each total.
                Display to the user how many times each Total came up:
            */

            Random dice = new Random();
            int d1;
            int d2;
            int toss;
            int total;
            int y;
            int avg;
            int[] tally = new int[11];
         

            Console.WriteLine("How many times should we throw the dice?");
            toss = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < toss; x++)
            {
                d1 = dice.Next(1, 7);
                d2 = dice.Next(1, 7);
                total = d1 + d2;
                y = total - 2;
               

                Console.WriteLine("You've rolled " + d1 + " and " + d2);
                Console.WriteLine("Your total: " + total);
                Console.WriteLine();
                tally[y]++;
            }

            for (int x = 0; x < 11; x++)
            {
                total = x + 2;
                Console.WriteLine("Total of " + total + " :" + tally[x] + " times");
               
            }

            Console.WriteLine();

            for (int x = 0; x < 11; x++)
            {
                total = x + 2;
                avg = tally[x] / toss;
                Console.WriteLine("Total of " + total + " AVG: " + avg + " percent of the rolls");
            }
            
            

            /* I rewrote the program twice. I made the variables more concise. I placed the repeating C.WL in a loop
             * with the tallied values list. Note: Variable y is created to access location in the list. I used the 
             * equation total - 2 because in the array list the position 0 will start with 2 because it is
             * the smallest possible total to come first in this list of values.
             */

        }
    }
}
