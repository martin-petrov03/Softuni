using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int devider = int.Parse(Console.ReadLine());
       
            numbers = numbers
                .Where(x => x % devider != 0)
                .Reverse()
                .ToArray();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}