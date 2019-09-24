using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(line);
            string commandInfo = Console.ReadLine().ToLower();
            
            while (commandInfo != "end")
            {
                string[] items = commandInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (items[0].ToLower())
                {
                    case "add":
                        for (int i = 1; i < items.Length; i++)
                        {                            
                            stack.Push(int.Parse(items[i]));
                        }
                        break;
                    case "remove":
                        int count = int.Parse(items[1]);
                        if (count <= stack.Count())
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }                        
                        break;
                    default:
                        //Console.WriteLine("Invalid Command!");
                        break;
                }

                commandInfo = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }        
    }
}