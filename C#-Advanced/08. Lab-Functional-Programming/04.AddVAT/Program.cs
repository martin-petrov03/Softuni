using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList()                
                .ForEach(x => Console.WriteLine($"{(x + 0.2 * x):f2}"));
        }
    }
}