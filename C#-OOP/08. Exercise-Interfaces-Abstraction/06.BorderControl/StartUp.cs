using System;
using System.Collections.Generic;

namespace _06.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var detained = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] items = input.Split();
                string id;

                if (items.Length == 2)
                {                    
                    id = items[1];
                }
                else
                {                    
                    id = items[2];
                }

                detained.Add(id);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            PrintDetainedIds(detained, input);
        }

        private static void PrintDetainedIds(HashSet<string> hashset, string searchedId)
        {
            foreach (string id in hashset)
            {
                if (id.EndsWith(searchedId))
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}
