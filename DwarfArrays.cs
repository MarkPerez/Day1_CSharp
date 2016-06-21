using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Grumpy", "Bashful", "Dopey" };
            string dwarfDinner;
            string dwarfDrink;
            for (var i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", what would you like for dinner?");
                dwarfDinner = Console.ReadLine();
                Console.WriteLine("And to drink?");
                dwarfDrink = Console.ReadLine();
                Console.WriteLine(sevenDwarves[i] + ", your " + dwarfDinner + " and " + dwarfDrink + " are ready.");
            }

            for (var i = 0; i < sevenDwarves.Length; i++) {
                Console.WriteLine("Your dinner is ready " + sevenDwarves[i]);
            }

            foreach (string s in sevenDwarves)
            {
                Console.WriteLine("Your drink is ready " + s);
            }
        }
    }
}
