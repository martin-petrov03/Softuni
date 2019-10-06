using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int col = 0; col < matrixSize; col++)
            {
                int[] line = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for(int row = 0; row < matrixSize; row++)
                {
                    matrix[row, col] = line[row];
                }
            }

            int index = 0;
            int primaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == index && col == row)
                    {
                        primaryDiagonalSum += matrix[row, col];
                        index++;
                    }
                    if (index == primaryDiagonalSum)
                    {
                        break;
                    }
                }
            }

            index = matrixSize - 1;
            int secondaryDiagonalSum = 0;           
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                secondaryDiagonalSum += matrix[index, col];
                index--;                    
            }
            int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}