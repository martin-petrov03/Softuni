using System;

namespace _05.Christmas_Sock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(
              '|' + new string('-', n * 2) + '|');
            Console.WriteLine(
              '|' + new string('*', n * 2) + '|');
            Console.WriteLine(
              '|' + new string('-', n * 2) + '|');

            int count1 = 2;
            for (int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine(
                    "|" + new string('-', i) + new string('~', count1) + new string('-', i) + "|");
                count1 += 2;
            }
            count1 -= 2;
            int count2 = count1;
            for (int i = 2; i <= n - 1; i++)
            {
                count2 -= 2;
                Console.WriteLine(
                    "|" + new string('-', i) + new string('~', count2) + new string('-', i) + "|");
            }

            int dots = 2 * n + 1;
            Console.WriteLine("\\" + new string('.', 2 * n + 1) + "\\");
            for (int row = 1; row <= n + 2; row++)
            {
                if (row == n / 2)
                    Console.WriteLine(
                        new string('-', row) + '\\' +
                        new string('.', (2 * n - 4) / 2) +
                        "MERRY" + new string('.', (2 * n - 4) / 2) + '\\');
                else if (row == n / 2 + 2)
                    Console.WriteLine(new string('-', row) + '\\' + new string('.', (2 * n - 4) / 2) + "X-MAS" + new string('.', (2 * n - 4) / 2) + '\\');
                else if (row == n + 2)
                    Console.WriteLine(new string('-', row) + '\\' + new string('_', 2 * n + 1) + ')');
                else
                    Console.WriteLine(new string('-', row) + '\\' + new string('.', 2 * n + 1) + '\\');
            }
        }
    }
}