using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());

            string[] items = Console.ReadLine().Split();
            Stack<string> elements = new Stack<string>(items);
            Queue<string> halls = new Queue<string>();
            List<int> groups = new List<int>();

            int currentCapacity = 0;
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                string currentElement = elements.Pop();
                bool isNumber = Int32.TryParse(currentElement, out int num);
                if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }
                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (num + currentCapacity > maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", groups)}");
                        groups.Clear();
                        currentCapacity = 0;
                    }

                    if (halls.Count > 0)
                    {
                        groups.Add(num);
                        currentCapacity += num;
                    }                    
                }
            }
        }
    }
}