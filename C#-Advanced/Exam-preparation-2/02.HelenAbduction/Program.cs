using System;

namespace HelenAbduction
{
    class Program
    {
        static int parisRow;
        static int parisCol;

        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            char[][] field = new char[size][];

            int parisRow = -1;
            int parisCol = -1;           

            for (int row = 0; row < field.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                field[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    field[row][col] = input[col];
                    
                    if (field[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }

            bool won = false;            
            while (energy > 0)
            {
                string[] command = Console.ReadLine().Split();
                string direction = command[0].ToLower();
                int spawnRow = int.Parse(command[1]);
                int spawnCol = int.Parse(command[2]);

                field[spawnRow][spawnCol] = 'S';
                field[parisRow][parisCol] = '-';

                if (direction == "up")
                {
                    if (parisRow - 1 >= 0)
                    {
                        parisRow--;
                    }
                }
                else if (direction == "down")
                {
                    if (parisRow + 1 < field.Length)
                    {
                        parisRow++;
                    }
                }
                else if (direction == "left")
                {
                    if (parisCol - 1 >= 0)
                    {
                        parisCol--;
                    }
                }
                else if (direction == "right")
                {
                    if (parisCol + 1 < field[parisRow].Length)
                    {
                        parisCol++;
                    }
                }
                energy--;

                if (field[parisRow][parisCol] == 'S')
                {
                    energy -= 2;
                    field[parisRow][parisCol] = 'P';
                }
                else if (field[parisRow][parisCol] == 'H')
                {
                    won = true;
                    field[parisRow][parisCol] = '-';
                    break;
                }
                else if (field[parisRow][parisCol] == '-')
                {
                    field[parisRow][parisCol] = 'P';
                }

                if (energy <= 0)
                {
                    field[parisRow][parisCol] = 'X';
                    break;
                }
            }
            
            if (won)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }

            PrintField(field);
        }

        private static void PrintField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = field[row];

                Console.WriteLine(String.Join("", currentRow));
            }
        }
    }
}