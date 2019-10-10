using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops
                = new SortedDictionary<string, Dictionary<string, double>>();

            string[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (line[0] != "Revision")
            {
                if (!shops.ContainsKey(line[0]))
                {
                    shops.Add(line[0], new Dictionary<string, double>());
                }
                
                if(!shops[line[0]].ContainsKey(line[1]))
                {
                    shops[line[0]].Add(line[1], 0);
                }

                shops[line[0]][line[1]] = double.Parse(line[2]);


                line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var shop in shops)
            {
                string shopName = shop.Key;
                var products = shop.Value;

                Console.WriteLine($"{shopName}->");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
