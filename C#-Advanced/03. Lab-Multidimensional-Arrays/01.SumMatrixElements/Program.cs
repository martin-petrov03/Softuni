using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countRows = count[0];
            int countColumns = count[1];

            int[,] matrix = new int[countRows, countColumns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            Console.WriteLine(countRows);
            Console.WriteLine(countColumns);

            int sum = 0;
            foreach (int item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}