using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < countPeople; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(", ");
                string name = line[0];
                int age = int.Parse(line[1]);

                people.Add(new KeyValuePair<string, int>(name, age));
            }

            string filter = Console.ReadLine();
            int selectedAge = int.Parse(Console.ReadLine());
            string[] formatItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            people.Where(p => filter.Trim() == "younger" ? p.Value < selectedAge : p.Value >= selectedAge)
                .ToList()
                .ForEach(p => Printer(p, formatItems));
        }

        static void Printer(KeyValuePair<string, int> person, string[] formatItems)
        {
            if (formatItems.Length == 2)
            {
                Console.WriteLine(formatItems[0] == "name" ? $"{person.Key} - {person.Value}" : $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(formatItems[0] == "name" ? $"{person.Key}" : $"{ person.Value}");
            }
        }
    }
}