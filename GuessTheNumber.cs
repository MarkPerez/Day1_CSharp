using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genRan = new Random();
            int secretNumber = genRan.Next(1, 11);
            int numberGuess;
            do
            {
                Console.WriteLine("Can you guess the number between 1 and 10? Enter your guess below:");
                numberGuess = Convert.ToInt32(Console.ReadLine());
                if (numberGuess < secretNumber)
                {
                    Console.WriteLine("Your guess is to low!");
                }
                else if (numberGuess > secretNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }
            }
            while (numberGuess != secretNumber);
            Console.WriteLine("Correct!");
        }
    }
}
