using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lowerBount = inputNums[0];
            int upperBount = inputNums[1];

            List<int> numbers = new List<int>();
            string numberType = Console.ReadLine();

            for (int i = lowerBount; i <= upperBount; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isOdd = number => number % 2 != 0;
            Predicate<int> isEven = number => number % 2 ==  0;

            Action<List<int>> printNumbers = arrOfNumbers => 
                Console.WriteLine(String.Join(" ", arrOfNumbers));

            if (numberType == "odd")
            {
                numbers = numbers
                    .Where(x => isOdd(x))
                    .ToList();
            }
            else if (numberType == "even")
            {
                numbers = numbers
                    .Where(x => isEven(x))
                    .ToList();
            }
            printNumbers(numbers);
        }
    }
}