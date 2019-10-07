using System;
using System.Linq;

namespace _03.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int countRows = matrixSize[0];
            int countCols = matrixSize[1];
            int[,] matrix = new int[countRows, countCols];

            //fill the matrix
            for (int row = 0; row < countRows; row++)
            {
                int[] line = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
                for (int col = 0; col < countCols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = 0;
            int selectedCol = 0;
            for (int row = 0; row < countRows - 2; row++)
            {
                for (int col = 0; col < countCols - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        selectedRow = row;
                        selectedCol = col;
                    }
                }
            }

            //Print the sum and selected matrix
            Console.WriteLine("Sum = " + maxSum);
            for (int row = selectedRow; row <= selectedRow + 2; row++)
            {
                for (int col = selectedCol; col <= selectedCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}