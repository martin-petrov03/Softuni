using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] board = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                char[] inputRow = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    board[row, col] = inputRow[col];
                }
            }

            int counter = 0;
            while (true)
            {                
                int knightsCount = 0;
                int knightsRow = 0;
                int knightsCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentCount = 0;

                        if (board[row, col] == 'K')
                        {
                            if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                                                        
                        }

                        if (currentCount > knightsCount)
                        {
                            knightsCount = currentCount;
                            knightsRow = row;
                            knightsCol = col;
                        }
                    }
                }

                if (knightsCount == 0)
                {
                    break;
                }

                board[knightsRow, knightsCol] = 'O';
                counter++;
            }
            Console.WriteLine(counter);
        }

        private static bool IsInside(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) && desiredRow >= 0
                && desiredCol < board.GetLength(1) && desiredCol >= 0;            
        }
    }
}