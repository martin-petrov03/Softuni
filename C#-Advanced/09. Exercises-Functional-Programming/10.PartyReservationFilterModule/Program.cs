using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string filter = Console.ReadLine();

            List<string> filters = new List<string>();

            while (filter != "Print")
            {
                string[] filterInfo = filter.Split(";");
                if (filterInfo[0] == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (filterInfo[0] == "Remove filter")
                {
                    filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                }

                filter = Console.ReadLine();
            }

            Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWithFilter = (name, param) => name.EndsWith(param);
            Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);

            foreach (var currentFilter in filters)
            {
                string[] currentFilterInfo = currentFilter.Split(";");
                string action = currentFilterInfo[0];
                string param = currentFilterInfo[1];
                if (action == "Starts with")
                {
                    names = names.Where(n => !startsWithFilter(n, param)).ToArray();
                }
                else if (action == "Ends with")
                {
                    names = names.Where(n => !endsWithFilter(n, param)).ToArray();
                }
                else if (action == "Length")
                {
                    names = names.Where(n => !lengthFilter(n, int.Parse(param))).ToArray();
                }
                else if (action == "Contains")
                {
                    names = names.Where(n => !containsFilter(n, param)).ToArray();
                }
            }

            Console.WriteLine(String.Join(" ", names));
        }
    }
}