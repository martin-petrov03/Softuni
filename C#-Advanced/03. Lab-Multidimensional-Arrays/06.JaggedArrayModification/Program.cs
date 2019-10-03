using System;
using System.Linq;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedArr[i] = numbers;
            }

            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string operation = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0
                    || row > rows
                    || col < 0
                    || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }

                switch (operation)
                {
                    case "add":
                        jaggedArr[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArr[row][col] -= value;
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (int[] item in jaggedArr)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}