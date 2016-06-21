using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codeDictionary = new Dictionary<string, string>();
            codeDictionary.Add("C#", "Number One");
            codeDictionary.Add("Javascript", "Number Two");
            codeDictionary.Add("Java", "Number Three");

            Console.WriteLine("Which is your favourite coding language? Type in the name or number to see if it is in the dictionary. You can also add, edit and remove entries by typing in the appropriate command.");
            string userCommand = Console.ReadLine();


        }
    }
}
