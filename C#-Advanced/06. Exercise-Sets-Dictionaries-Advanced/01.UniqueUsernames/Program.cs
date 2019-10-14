using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueUsernames = new HashSet<string>();
            int countLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                uniqueUsernames.Add(input);
            }

            foreach (string username in uniqueUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
