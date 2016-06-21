using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[5];
            for (var i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            double averageOfArray = numbersArray.Average();
            Console.WriteLine("The average is " + averageOfArray);

            int[,] twoDimensionalArray = new int[5, 5];
            for (var i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (var j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int sumOfRows = 0;
            int sumOfColumns = 0;
            int overallTotal = 0;

            for (var i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (var j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    sumOfRows += twoDimensionalArray[i,j];
                    sumOfColumns += twoDimensionalArray[j, i];
                    overallTotal = sumOfRows + sumOfColumns;
                }
            }

            Console.WriteLine(overallTotal);



        }
    }
}
