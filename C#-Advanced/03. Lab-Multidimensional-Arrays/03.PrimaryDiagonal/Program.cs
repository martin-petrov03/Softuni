using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
          int countElements = int.Parse(Console.ReadLine());
          int[,] matrix = new int[countElements, countElements];
          
          for (int i = 0; i < matrix.GetLength(0); i++)
          {
              int[] tokens = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
              for (int j = 0; j < matrix.GetLength(1); j++)
              {
                  matrix[i, j] = tokens[j];
              }
          }
          
          int index = 0;
          int diagonalSum = 0;
          
          for (int row = 0; row < matrix.GetLength(0); row++)
          {
              for (int col = 0; col < matrix.GetLength(1); col++)
              {    
                  if (col == index && col == row)
                  {                        
                      diagonalSum += matrix[row, col];
                      index++;
                  }
                  if (index == countElements)
                  {
                      break;
                  }
              }
          }
          Console.WriteLine(diagonalSum);
        }
    }
}