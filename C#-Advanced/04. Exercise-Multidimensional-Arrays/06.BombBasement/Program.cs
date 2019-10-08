using System;
using System.Linq;

namespace _06.BombBasement
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
            int[][] matrix = new int[countRows][];
            
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[countCols];
            }

            int[] coordinates = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int targetRow = coordinates[0];
            int targetCol = coordinates[1];
            int radius = coordinates[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);
                    if (isInRadius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }
            
            for (int row = 0; row < matrix.Length; row++)
            {
                int counter = 0;
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 1)
                    {
                        counter++;
                        matrix[row][col] = 0;
                    }
                }
                for (int col = 0; col < counter; col++)
                {
                    matrix[row][col] = 1;
                }
            }
        }
    }
}
