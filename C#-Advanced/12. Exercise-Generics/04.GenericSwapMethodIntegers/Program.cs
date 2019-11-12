using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            box.Swap(indexes[0], indexes[1]);

            string result = box.ToString();
            Console.WriteLine(result);
        }
    }
}