using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> countSameValues = new Dictionary<double, int>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (!countSameValues.ContainsKey(inputArr[i]))
                {
                    countSameValues[inputArr[i]] = 1;
                }
                else {
                    countSameValues[inputArr[i]]++;
                }
            }

            foreach (var num in countSameValues)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
