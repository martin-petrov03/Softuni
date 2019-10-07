using System;
using System.Linq;

namespace _04.MatrixShuffling
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
            string[,] matrix = new string[countRows, countCols];

            //fill the matrix
            for (int row = 0; row < countRows; row++)
            {
                string[] line = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < countCols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);            

            while (command[0] != "END")
            {
                if (command[0] == "swap")
                {                    
                    try
                    {                   
                        string firstValueTemp = matrix[int.Parse(command[1]), int.Parse(command[2])];
                        string secondValueTemp = matrix[int.Parse(command[3]), int.Parse(command[4])];
                        
                        matrix[int.Parse(command[3]), int.Parse(command[4])] = firstValueTemp;
                        matrix[int.Parse(command[1]), int.Parse(command[2])] = secondValueTemp;

                        for (int row = 0; row < countRows; row++)
                        {                             
                            for (int col = 0; col < countCols; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                    }                                     
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}