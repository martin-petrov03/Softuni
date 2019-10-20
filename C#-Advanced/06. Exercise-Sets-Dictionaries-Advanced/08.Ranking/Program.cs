using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] tokens = input.Split(":");
                string contestName = tokens[0];
                string password = tokens[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>");
                string contestName = tokens[0];
                string contestPassword = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contests.ContainsKey(contestName) || contests[contestName] != contestPassword)
                {
                    input = Console.ReadLine();
                    continue;
                }                

                if (!submissions.ContainsKey(username))
                {
                    submissions.Add(username, new Dictionary<string, int>());
                }

                if (!submissions[username].ContainsKey(contestName))
                {
                    submissions[username].Add(contestName, 0);
                }

                if (submissions[username][contestName] < points)
                {
                    submissions[username][contestName] = points;
                }                
                
                input = Console.ReadLine();
            }

            var winner = submissions
                .OrderByDescending(v => v.Value.Values.Sum(x => x))
                .FirstOrDefault();

            string winnerName = winner.Key;
            int winnerPoint = winner.Value.Values.Sum(x => x);
            Console.WriteLine($"Best candidate is {winnerName} with total {winnerPoint} points.");
            Console.WriteLine("Ranking:");

            foreach (var (key, value) in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(key);

                foreach (var (contestName, points) in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}