using System;
using System.Linq;
using System.Collections.Generic;

namespace MatrixMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int countRows = matrixSize[0];
            int countColumns = matrixSize[1];

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

            //int[,] biggestMatrix = new int[2, 2];
            int selectedMatrixRow = 0;
            int selectedMatrixColumn = 0;
            int biggestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int rowSum = matrix[row, col] + matrix[row, col + 1];
                    int colSum = matrix[row + 1, col] + matrix[row + 1, col + 1];
                    int currentSum = rowSum + colSum;

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        selectedMatrixRow = row;
                        selectedMatrixColumn = col;
                        //biggestMatrix[0, 0] = matrix[row, col];
                        //biggestMatrix[0, 1] = matrix[row, col + 1];
                        //biggestMatrix[1, 0] = matrix[row + 1, col];
                        //biggestMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            //for (int row = 0; row < biggestMatrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < biggestMatrix.GetLength(1); col++)
            //    {
            //        Console.Write(biggestMatrix[row, col]);
            //        if (col != biggestMatrix.GetLength(1) - 1)
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine(
                $"{matrix[selectedMatrixRow, selectedMatrixColumn]} " +
                $"{ matrix[selectedMatrixRow, selectedMatrixColumn + 1]}\n" +
                $"{matrix[selectedMatrixRow + 1, selectedMatrixColumn]}" +
                $"{matrix[selectedMatrixRow + 1, selectedMatrixColumn + 1]}\n"
            );
            Console.WriteLine(biggestSum);
        }
    }
}