using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumAMA
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Prompt a user to enter two integers. (This program should only use integers!)
            //   List all of the prime numbers between those two integers.



            int x;
            int y;
            int checker;

            Console.WriteLine("Give me a number between 0-5.");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Give me a number between 20-30.");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("These are all the prime numbers between those two integers.");

            Console.WriteLine();

            
            while (x <= y)
            {
                checker = 0;
                for (int j = 2; j <= x / 2; j++)

                {
                    if (x % j == 0)
                    {
                        checker = 1;

                    }       
                                 
                }
              if  (checker == 0)
                {
                    Console.WriteLine(x);
                }
               
                x++;
            }

            Console.ReadKey();



            // I want to start with the users number and then print every number until I get to their second number.
            // Then I want to check if each number between those numbers is prime or not.

            // A prime number is a number divisible by itself and 1
            // a composite number is divisible by 1, itself, and another divisor




      

  


            }
        }
    }


 
   
