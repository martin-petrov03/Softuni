using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggerCollection = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();
            
            while (!input.Contains("Statistics"))
            {
                if (input.Contains("joined"))
                {
                    string username = input.Split()[0];
                    if (!vloggerCollection.ContainsKey(username))
                    {
                        vloggerCollection.Add(username, new Dictionary<string, HashSet<string>>());
                        vloggerCollection[username].Add("followings", new HashSet<string>());
                        vloggerCollection[username].Add("followers", new HashSet<string>());
                    }
                    
                }
                else if (input.Contains("followed"))
                {
                    string[] line = input.Split();
                    string follower = line[0];
                    string follows = line[2];

                    if (!vloggerCollection.ContainsKey(follows)
                        || !vloggerCollection.ContainsKey(follower)
                         || follower == follows)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    vloggerCollection[follows]["followers"].Add(follower);
                    vloggerCollection[follower]["followings"].Add(follows);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerCollection.Count} vloggers in its logs.");

            int count = 1;
            var sortedVloggers = vloggerCollection
                .OrderByDescending(f => f.Value["followers"].Count)
                .ThenBy(f => f.Value["followings"].Count)
                .ToDictionary(k => k.Key, y => y.Value);

            foreach (var (username, values) in sortedVloggers)
            {
                int followersCount = sortedVloggers[username]["followers"].Count;
                int followingCount = sortedVloggers[username]["followings"].Count;

                Console.WriteLine($"{count}. {username} : {followersCount} followers, {followingCount} following");

                if (count == 1)
                {
                    List<string> sortedFollowers = values["followers"].OrderBy(x => x).ToList();
                    foreach (var currentFollower in sortedFollowers)
                    {
                        Console.WriteLine($"*  {currentFollower}");
                    }
                }
                count++;
            }    
        }
    }
}