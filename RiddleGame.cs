using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Riddle Game. You will have three guesses for each riddle. Press Enter to begin.");
            Console.ReadLine();
            
            //riddle one
            Console.WriteLine("They can be bent and they can be broken, but they cannot be touched. What are they?");
            Console.WriteLine("Enter your guess below:");

            //the user's guess
            string userAnswer = Console.ReadLine();

            //score tracker
            int correctScores = 0;

            //number of guesses tracker
            int numberOfGuesses = 0;

            //the answer
            string riddleOneAnswer = "rules";

            while (!userAnswer.Contains(riddleOneAnswer))
            {
                Console.WriteLine("Incorrect.");
                numberOfGuesses++;
                if (numberOfGuesses == 3)
                {
                    break;
                }
                Console.WriteLine("Enter your guess below:");
                userAnswer = Console.ReadLine();
            }
            if (numberOfGuesses < 3)
            {
                Console.WriteLine("Correct!");
                correctScores++;
            }            

            //riddle 2
            Console.WriteLine("\n" + "It weighs less than air, but most people cannot hold it for more than a minute. What is it?");
            string riddleTwoAnswer = "breath";
            numberOfGuesses = 0;

            do
            {
                Console.WriteLine("Enter your guess below:");
                userAnswer = Console.ReadLine();
                if (!userAnswer.Contains(riddleTwoAnswer))
                {
                    Console.WriteLine("Incorrect.");
                    numberOfGuesses++;
                    if (numberOfGuesses == 3)
                    {
                        break;
                    }
                }
            }
            while (!userAnswer.Contains(riddleTwoAnswer));
            if (numberOfGuesses < 3)
            {
                Console.WriteLine("Correct!");
                correctScores++;
            }

            //riddle 3
            Console.WriteLine("\n" + "A man named Don Rowe wants to rearrange the letters of his name to make one word. What is the result?");
            string riddleThreeAnswer = "one word";
            numberOfGuesses = 0;

            do
            {
                Console.WriteLine("Enter your guess below:");
                userAnswer = Console.ReadLine();
                if (!userAnswer.Contains(riddleThreeAnswer))
                {
                    Console.WriteLine("Incorrect.");
                    numberOfGuesses++;
                    if (numberOfGuesses == 3)
                    {
                        break;
                    }
                }
            }
            while (!userAnswer.Contains(riddleThreeAnswer));
            if (numberOfGuesses < 3)
            {
                Console.WriteLine("Correct!");
                correctScores++;
            }
            Console.WriteLine("\n" + "The game is now over. You scored " + correctScores + " out of 3.");
        }
    }
}
