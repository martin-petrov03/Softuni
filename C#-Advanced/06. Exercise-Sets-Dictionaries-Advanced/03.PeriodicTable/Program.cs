using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();

            int countLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string item in input)
                {
                    elements.Add(item);
                }
            }
            
            foreach (string element in elements)
            {
                Console.Write(element + " ");
            }
        }
    }
}