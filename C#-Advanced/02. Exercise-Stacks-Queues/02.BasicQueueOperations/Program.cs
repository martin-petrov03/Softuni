using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] configArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();

            int countElementsToEnqueue = configArr[0];
            int countElementsToDequeue = configArr[1];
            int specialElement = configArr[2];

            for (int i = 0; i < countElementsToEnqueue; i++)
            {
                queue.Enqueue(inputArr[i]);
            }
            for (int i = 0; i < countElementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(specialElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
