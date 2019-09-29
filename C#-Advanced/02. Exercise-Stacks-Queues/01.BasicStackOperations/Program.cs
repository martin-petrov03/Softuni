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
            Stack<int> stack = new Stack<int>();

            int countElementsToPush = configArr[0];
            int countElementsToPop = configArr[1];
            int specialElement = configArr[2];

            for (int i = 0; i < countElementsToPush; i++)
            {               
               stack.Push(inputArr[i]);                               
            }
            for (int i = 0; i < countElementsToPop; i++) {
                stack.Pop();            
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(specialElement))
                {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine(stack.Min());
                }                
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
