using System;
using System.Linq;

namespace _2x2_SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (matrixSize.Length < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                int rowsCount = matrixSize[0];
                int colsCount = matrixSize[1];

                string[,] matrix = new string[rowsCount, colsCount];

                //fill the matrix
                for (int row = 0; row < rowsCount; row++)
                {
                    string[] line = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                    for (int col = 0; col < colsCount; col++)
                    {
                        matrix[row, col] = line[col];
                    }
                }

                int counter = 0;
                for (int row = 0; row < rowsCount - 1; row++)
                {
                    for (int col = 0; col < colsCount - 1; col++)
                        if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            counter++;
                        }
                }
                Console.WriteLine(counter);
            }            
        }
    }
}