using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "One", "Two", "Three" };

            string text = "";
            for (var i = 0; i < newArray.Length; i++)
            {
                try
                {
                    text += newArray[i + 1];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }
    }
}
