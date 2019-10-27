using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {            
            Func<int[], int> minValue = arrOfNums =>
            {
                int min = int.MaxValue;
                foreach (int currentNum in arrOfNums)
                {
                    if (min > currentNum)
                    {
                        min = currentNum;
                    }
                }
                return min;
            };

            int[] inputNums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(minValue(inputNums));
        }
    }
}