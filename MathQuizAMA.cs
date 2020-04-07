using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuizAMA
{
    class Program

        // Create a short fill in the blank math quiz.
        // Prompt the user with a question and accept a typed answer as input.
        // Let the user know if they got the answer right or wrong.
        // Determine how many questions the user answers correctly and incorrectly.
        // Your math quiz should include at least 5 questions.

    {
        static void Main(string[] args)
        {
            int score = 0;
            int a, b, c, d, e;
            

            Console.WriteLine("Welcome to your first Math Quiz!");

            Console.WriteLine();

            Console.WriteLine("1. 5 +    = 9 ");
             a = Convert.ToInt32(Console.ReadLine());

            if (a == 4)
            {
                Console.WriteLine("That's Right!");
                score = score + 1;
            }

            else

                Console.WriteLine("Incorrect");
          

            Console.WriteLine();

            Console.WriteLine("2. 2 *   = 8 ");
            b = Convert.ToInt32(Console.ReadLine());

            if (b == 4)
            {
                Console.WriteLine("That's Right!");
                score = score + 1;
            }

            else
                Console.WriteLine("Incorrect");

            Console.WriteLine();

            Console.WriteLine("3. 4 /    = 1 ");
            c = Convert.ToInt32(Console.ReadLine());

            if (c == 4)
            {
                Console.WriteLine("That's Right!");
                score = score + 1;
            }

            else
                Console.WriteLine("Incorrect");

            Console.WriteLine();

            Console.WriteLine("4. 4 -    = 0 ");
            d = Convert.ToInt32(Console.ReadLine());

            if (d == 4)
            {
                Console.WriteLine("That's Right!");
                score = score + 1;
            }

            else
                Console.WriteLine("Incorrect");

            Console.WriteLine();

            Console.WriteLine("5. 4 * 4  -    = 12 ");
            e = Convert.ToInt32(Console.ReadLine());

            if (e == 4)
            {
                Console.WriteLine("That's Right!");
                score = score + 1;
            }

            else
                Console.WriteLine("Incorrect");

            Console.WriteLine("You got ");
            Console.Write(score);
            Console.WriteLine(" out of 5 correct!");

            if (score <= 2)
            {
                Console.WriteLine("You failed the quiz this time!");
                Console.Write("Please retake the quiz!");
            }

            Console.ReadKey();






        }
    }
}
