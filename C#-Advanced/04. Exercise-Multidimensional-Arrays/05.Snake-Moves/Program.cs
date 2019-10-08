using System;
using System.Linq;

namespace _05.Snake_Moves
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

            char[,] matrix = new char[countRows, countCols];
            string snake = Console.ReadLine();

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (counter >= snake.Length)
                        counter = 0;
                    matrix[row, col] = snake[counter++];                    
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);                    
                }
                Console.WriteLine();
            }
        }
    }
}