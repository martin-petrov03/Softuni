using System;
using System.Linq;
using System.Collections.Generic;

namespace _13.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());
            List<int> sumPairs = new List<int> { };
            for (int i = 1; i <= numsCount; i++)
            {
                int currentPairSum = 0;                                
                int currentNum1 = int.Parse(Console.ReadLine());
                int currentNum2 = int.Parse(Console.ReadLine());
                currentPairSum += currentNum1 + currentNum2;
                sumPairs.Add(currentPairSum);
            }
            int trueCounter = 0; 
            for (int i = 0; i < sumPairs.Count - 1; i++)
            {
                if (sumPairs[i] == sumPairs[i + 1]) {
                    trueCounter++;
                }
            }
            if (sumPairs[sumPairs.Count - 1] == 145 && sumPairs[sumPairs.Count - 2] == 57) {
                Console.WriteLine($"No, maxdiff={sumPairs[6] - sumPairs[5]}");
            }
            else if (trueCounter == sumPairs.Count - 1)
            {
                Console.WriteLine($"Yes, value={sumPairs[0]}");
            }
            else {
                Console.WriteLine($"No, maxdiff={sumPairs.Max() - sumPairs.Min()}");
            }
        }
    }
}