using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" -> ");
                string color = line[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                string[] clothes = line[1].Split(',', StringSplitOptions.RemoveEmptyEntries);  

                foreach (var cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }
                    wardrobe[color][cloth]++;
                }
            }

            string[] targetClothInfo = Console.ReadLine()
                .Split();

            string targetColor = targetClothInfo[0];
            string targetCloth = targetClothInfo[1];

            foreach (var (color, clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (cloth, count) in clothes)
                {
                    string result = $"* {cloth} - {count}";
                    if (color == targetColor && cloth == targetCloth)
                    {
                        result += " (found!)";
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}