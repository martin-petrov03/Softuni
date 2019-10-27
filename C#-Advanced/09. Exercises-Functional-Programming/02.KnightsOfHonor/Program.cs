using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printFormatedNames = names =>
            Console.WriteLine("Sir " + String.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printFormatedNames(inputNames);
        }
    }
}