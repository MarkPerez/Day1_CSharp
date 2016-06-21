using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a list of books:");
            List<string> bookList = new List<string> { "Lord of the Flies", "Lord of the Rings", "Great Expectations" };

            for (var i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i]);
            }

            bool done = false;
            do
            {
            Console.WriteLine("What would you like to do? You can add, delete, list, sort. Please type in your command. Type 'done' when you are finished.");

            string userCommand = Console.ReadLine();

         
                switch (userCommand)
                {
                    case "add":
                        Console.WriteLine("Please enter a book to add:");
                        string bookAddition = Console.ReadLine();
                        bookList.Add(bookAddition);
                        break;
                    case "delete":
                        Console.WriteLine("Please enter a book to delete:");
                        string bookDeletion = Console.ReadLine();
                        bookList.Remove(bookDeletion);
                        break;
                    case "list":
                        for (var i = 0; i < bookList.Count; i++)
                        {
                            Console.WriteLine(bookList[i]);
                        }
                        break;
                    case "sort":
                        bookList.Sort();
                        break;
                    case "done":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("That is not a valid command.");
                        break;
                }
            }
            while (done != true);
        }
    }
}
