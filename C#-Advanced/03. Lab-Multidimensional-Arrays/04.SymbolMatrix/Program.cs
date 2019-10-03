using System;
using System.Linq;

namespace SymbolMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int countElements = int.Parse(Console.ReadLine());
            char[,] matrix = new char[countElements, countElements];

            for (int col = 0; col < countElements; col++)
            {
                string tokens = Console.ReadLine();
                for (int row = 0; row < countElements; row++)
                {                    
                    matrix[row, col] = tokens[row];
                }
            }            

            char specialSymbol = char.Parse(Console.ReadLine());
            bool containsSpecialChar = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == specialSymbol)
                    {
                        containsSpecialChar = true;
                        Console.WriteLine($"({j}, {i})");
                        break;
                    }
                }
            }

            if (!containsSpecialChar)
            {
                Console.WriteLine($"{specialSymbol} does not occur in the matrix");
            }
        }
    }
}