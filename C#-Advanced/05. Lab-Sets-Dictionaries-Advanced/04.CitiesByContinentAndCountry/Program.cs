using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents
               = new Dictionary<string, Dictionary<string, List<string>>>();

            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (!continents.ContainsKey(line[0]))
                {
                    continents.Add(line[0], new Dictionary<string, List<string>>());
                }

                if (!continents[line[0]].ContainsKey(line[1]))
                {
                    continents[line[0]].Add(line[1], new List<string>());
                }

                continents[line[0]][line[1]].Add(line[2]);
            }
            
            foreach (var continent in continents)
            {
                var countries = continent.Value;
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in countries)
                {
                    Console.WriteLine($"{country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}