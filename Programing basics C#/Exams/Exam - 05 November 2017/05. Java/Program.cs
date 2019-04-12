using System;

namespace _05.Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  int.Parse(Console.ReadLine());
            int width = 3 * n + 6;
            int kliomba = ((3 * n) + 6) - (n + 2);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~{1}", new string(' ', n), new string(' ', n * 2 + 3));
            }
            Console.WriteLine(new string('=', width - 1));

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));
                }
                Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                for (int i = 0; i < n / 2 - 2; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));
                }

            }
            else
            {
                for (int i = 0; i < (n - 3) / 2; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));
                }
                Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', n), new string(' ', n - 1));
                for (int i = 0; i < (n - 3) / 2; i++)
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', n * 2 + 4), new string(' ', n - 1));

                }
            }
            Console.WriteLine(new string('=', width - 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string(' ', i), new string('@', kliomba));
                kliomba = kliomba - 2;
            }
            Console.WriteLine(new string('=', width - n));
        }
    }
}