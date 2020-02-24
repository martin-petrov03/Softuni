using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int countOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLines; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 4)
                {
                    buyers.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    buyers.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                var buyer = buyers.SingleOrDefault(b => b.Name == input);

                if (buyer != null)
                {
                    buyer.BuyFood();                    
                }

                input = Console.ReadLine();
            }

            int food = buyers.Sum(b => b.Food);
            Console.WriteLine(food);            
        }
    }
}
