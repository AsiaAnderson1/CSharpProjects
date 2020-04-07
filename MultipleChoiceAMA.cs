using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceAMA
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a multiple choice quiz. 
            // For each question, the user should be able to select between 2 or more options.
            // This will be easiest if those options are numeric (ex. 1, 2, 3, or 4)
            // Your multiple choice quiz should have at least 5 questions.          
            //  * **Bonus point if you have the user answer in letters instead of numbers

            string a, b, c, d, e;
            int score = 0;

            Console.WriteLine("Welcome to the first Multiple Choice Quiz!");

            Console.WriteLine();

            Console.WriteLine("Choose the letter that reflects the best answer.");

            Console.WriteLine();

            Console.WriteLine(" 1. How many degrees Celsius is 86 degrees Farenheit?");
            Console.WriteLine();
            Console.WriteLine("a. 30 degrees Celsius");
            Console.WriteLine("b. 45 degrees Celsius");
            Console.WriteLine("c. 60 degrees Celsius");
            a = Console.ReadLine();
            
            if (a == "a")
            {
                Console.WriteLine("That's correct!");
                score = score + 1;
            }

            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine();

            Console.WriteLine("2. What is the capital of Ohio?");
            Console.WriteLine();
            Console.WriteLine("a. Toledo");
            Console.WriteLine("b. Cleveland");
            Console.WriteLine("c. Columbus");
            b = Console.ReadLine();

            if (b  == "c")
            {
                Console.WriteLine("That's correct!");
                score = score + 1;
            }

            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine();

            Console.WriteLine("3. How many quarters are in a dollar?");
            Console.WriteLine();
            Console.WriteLine("a. 30");
            Console.WriteLine("b. 400");
            Console.WriteLine("c. 12");
            c = Console.ReadLine();

            if (c == "b")
            {
                Console.WriteLine("That's correct!");
                score = score + 1;
            }

            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine();

            Console.WriteLine("4. How many months are in a year?");
            Console.WriteLine();
            Console.WriteLine("a. 30");
            Console.WriteLine("b. 365");
            Console.WriteLine("c. 12");
            d = Console.ReadLine();

            if (d == "c")
            {
                Console.WriteLine("That's correct!");
                score = score + 1;
            }

            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine();

            Console.WriteLine("5. What company is the candy bar Snickers owned by?");
            Console.WriteLine();
            Console.WriteLine("a. Pepsi");
            Console.WriteLine("b. Mars Incorporated");
            Console.WriteLine("c. Johnson & Johnson Incorporated");
            e = Console.ReadLine();

            if (e == "b")
            {
                Console.WriteLine("That's correct!");
                score = score + 1;
            }

            else
            {
                Console.WriteLine("Incorrect!");
            }

            Console.WriteLine("You scored: ");
            Console.Write(score);
            Console.WriteLine(" out of 5 possible points!");
            Console.WriteLine("Thank you for taking the quiz!");

            Console.ReadKey();
        }
    }
}
