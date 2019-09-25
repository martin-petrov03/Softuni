using System;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(item => item % 2 == 0)
                .ToArray();         
            Console.WriteLine(String.Join(", ", inputArr));
        }
    }
}
