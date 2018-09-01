using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thinking of a number between 1-100...");

            Random r = new Random();
            int n = r.Next(0,100);

            bool lp = true;
            int tries = 1;

            while (lp)
            {

                Console.Write("Guess? ");

                int g = Convert.ToInt32(Console.ReadLine());

                if (g == n)
                {
                    Console.WriteLine("\nCongrats! You got it!");
                    lp = false;
                }
                else
                {
                    if (g > n)
                    {
                        Console.WriteLine("\nToo High! Guess Again!");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("\nToo Low! Guess Again!");
                        tries++;
                    }
                }
            }
            Console.Write("\nIt took you ");
            Console.Write(tries);
            Console.Write(" tries to get it right!");
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
