using System;
using System.Collections.Generic;

namespace _07._PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split();
            List<string> result = new List<string>();

            foreach (string name in names)
            {
                if (name.Length <= length)
                {
                    result.Add(name);
                }                
            }

            Console.WriteLine(String.Join("\n", result));
        }
    }
}