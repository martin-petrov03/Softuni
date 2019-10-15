using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int[] setsSizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < setsSizes[0]; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                firstSet.Add(currentNum);
            }

            for (int i = 0; i < setsSizes[1]; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                secondSet.Add(currentNum);
            }
            
            foreach (int currentItem in firstSet)
            {
                if (secondSet.Contains(currentItem))
                {
                    Console.Write(currentItem + " ");
                }
            }
        }
    }
}