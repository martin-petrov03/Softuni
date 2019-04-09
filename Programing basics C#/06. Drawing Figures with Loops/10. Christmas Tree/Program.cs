using System;

namespace _01.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n + 1) + '|');
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(
                    new string(' ', n - i) + 
                    new string('*', i) +
                    " " + "|" + " " +
                    new string('*', i) +
                    new string(' ', n - 1));
            }
        }
    }
}