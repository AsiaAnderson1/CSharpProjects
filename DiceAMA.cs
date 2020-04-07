using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceAMA
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
                Example Output:

                2: 10 times
                3: 12 times
                4: 16 times
                5: 20 times
                6: 22 times
                7: 25 times
                8: 23 times
                9: 19 times
                10: 15 times
                11: 12 times
                12: 8 times
            */

            Random toss = new Random();
            int d1;
            int d2;
            int throws;
            int total;         
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int c5 = 0;
            int c6 = 0;
            int c7 = 0;
            int c8 = 0;
            int c9 = 0;
            int c10 = 0;
            int c11 = 0;
            int c12 = 0;




            Console.WriteLine("How many times should we throw the dice?");
            throws = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= throws; i++)
            {
                d1 = toss.Next(1, 7);
                d2 = toss.Next(1, 7);
                total = d1 + d2;

                Console.WriteLine(" You threw a : " + d1 + " and a " + d2);
                Console.WriteLine(" That's a total of " + total);
                Console.WriteLine();




                if (total == 2)
                {
                    c2++;
                }
                if (total == 3)
                {
                    c3++;
                }
                if (total == 4)
                {
                    c4++;
                }
                if (total == 5)
                {
                    c5++;
                }
                if (total == 6)
                {
                    c6++;
                }
                if (total == 7)
                {
                    c7++;
                }
                if (total == 8)
                {
                    c8++;
                }
                if (total == 9)
                {
                    c9++;

                }

                if (total == 10)
                {
                    c10++;
                }

                if (total == 11)
                {
                    c11++;
                }

                if (total == 12)
                {
                    c12++;
                }


            }
           
           
            Console.WriteLine("Total of 2: " + c2 + " times");
            Console.WriteLine("Total of 3: " + c3 + " times");
            Console.WriteLine("Total of 4: " + c4 + " times");
            Console.WriteLine("Total of 5: " + c5 + " times");
            Console.WriteLine("Total of 6: " + c6 + " times");
            Console.WriteLine("Total of 7: " + c7 + " times");
            Console.WriteLine("Total of 8: " + c8 + " times");
            Console.WriteLine("Total of 9: " + c9 + " times");
            Console.WriteLine("Total of 10: " + c10 + " times");
            Console.WriteLine("Total of 11: " + c11 + " times");
            Console.WriteLine("Total of 12: " + c12 + " times");

            /* I need a new throw for each iteration and then I'll be finished with this program. I also need an array to keep track of the record of scores.
          
             right away you need a randomizer to generate the random number that will thrown when the dice are rolled. */







        }
      
    }
}
