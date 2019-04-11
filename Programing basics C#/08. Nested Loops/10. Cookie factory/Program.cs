using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int countParts = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int countBakes = 0;
                List<string> products = new List<string> { };
            while (true)
            {
                
                while (input != "Bake!") {

                    products.Add(input);
                    input = Console.ReadLine();
                }

                if (input == "Bake!")
                {
                    
                    if (products.Contains("eggs") && products.Contains("sugar") && products.Contains("flour"))
                        {
                        countBakes++;
                        Console.WriteLine($"Baking batch number {countBakes}...");
                        products.Clear();
                    }
                        else {
                            Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                        }
                   
                    if (countBakes >= countParts)
                    {
                        break;
                    }
                }               

                input = Console.ReadLine();
            }
        }
    }
}