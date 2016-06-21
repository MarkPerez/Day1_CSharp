using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentialElections
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The US Presidential election is coming! Who do you think will win? The candidates are as follows:");
            Console.WriteLine("Candidate A");
            Console.WriteLine("Candidate B");
            Console.WriteLine("Candidate C");
            Console.WriteLine("Candidate D");
            Console.WriteLine("Enter who you think will win below:");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "Candidate A":
                    Console.WriteLine("A safe choice.");
                    break;

                case "Candidate B":
                    Console.WriteLine("B wary, this one is dodgy.");
                    break;

                case "Candidate C":
                    Console.WriteLine("C for yourself, this one is good.");
                    break;

                case "Candidate D":
                    Console.WriteLine("Dream on.");
                    break;

                default:
                    Console.WriteLine("That is not a candidate.");
                    break;
            }
        }
    }
}   
