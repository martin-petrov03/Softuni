using System;

namespace _03.SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size,size];
            int stephanRow = -1;
            int stephanCol = -1;
            int firstBlackHoleRow = -1;
            int firstBlackHoleCol = -1;
            int secondBlackHoleRow = -1;
            int secondBlackHoleCol = -1;

            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'S')
                    {
                        stephanRow = row;
                        stephanCol = col;
                    }

                    if (matrix[row, col] == 'O')
                    {
                        if (firstBlackHoleRow == -1 && firstBlackHoleCol == -1)
                        {
                            firstBlackHoleRow = row;
                            firstBlackHoleCol = col;
                        }
                        else
                        {
                            secondBlackHoleRow = row;
                            secondBlackHoleCol = col;
                        }                        
                    }
                }
            }

            bool isOut = false;
            int stars = 0;
            while (stars < 50)
            {
                string command = Console.ReadLine();

                matrix[stephanRow, stephanCol] = '-';
                if (command == "up")
                {
                    if (stephanRow > 0)
                    {
                        stephanRow--;
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (stephanRow < size - 1)
                    {
                        stephanRow++;
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (stephanCol < size - 1)
                    {
                        stephanCol++;
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (stephanCol > 0)
                    {
                        stephanCol--;
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }    

                if (matrix[stephanRow, stephanCol] == 'O')
                {
                    matrix[firstBlackHoleRow, firstBlackHoleCol] = '-';
                    matrix[secondBlackHoleRow, secondBlackHoleCol] = '-';

                    if (stephanRow == firstBlackHoleRow && stephanCol == firstBlackHoleCol)
                    {
                        stephanRow = secondBlackHoleRow;
                        stephanCol = secondBlackHoleCol;
                    }
                    else
                    {
                        stephanRow = firstBlackHoleRow;
                        stephanCol = firstBlackHoleCol;
                    }
                }
                else if (Char.IsDigit(matrix[stephanRow, stephanCol])) 
                {
                    int currentStars = 0;

                    if (matrix[stephanRow, stephanCol] == '1')
                    {
                        currentStars = 1;
                    }
                    else if (matrix[stephanRow, stephanCol] == '2')
                    {
                        currentStars = 2;
                    }
                    else if (matrix[stephanRow, stephanCol] == '3')
                    {
                        currentStars = 3;
                    }
                    else if (matrix[stephanRow, stephanCol] == '4')
                    {
                        currentStars = 4;
                    }
                    else if (matrix[stephanRow, stephanCol] == '5')
                    {
                        currentStars = 5;
                    }
                    else if (matrix[stephanRow, stephanCol] == '6')
                    {
                        currentStars = 6;
                    }
                    else if (matrix[stephanRow, stephanCol] == '7')
                    {
                        currentStars = 7;
                    }
                    else if (matrix[stephanRow, stephanCol] == '8')
                    {
                        currentStars = 8;
                    }
                    else if (matrix[stephanRow, stephanCol] == '9')
                    {
                        currentStars = 9;
                    }

                    stars += currentStars;
                }

                matrix[stephanRow, stephanCol] = 'S';
            }

            if (isOut)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {stars}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}