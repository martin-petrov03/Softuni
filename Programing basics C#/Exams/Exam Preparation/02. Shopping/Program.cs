using System;

namespace _02._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countChocolates = int.Parse(Console.ReadLine());
            double milkQuality = double.Parse(Console.ReadLine());

            double chocolatePrise = countChocolates * 0.65;
            double milkPrise = milkQuality * 2.7;
            int mandariniCount = (int)Math.Floor(countChocolates - (countChocolates * 0.35));
            double mandariniPrise = mandariniCount * 0.2;

            double totalSum = chocolatePrise + milkPrise + mandariniPrise;

            if (totalSum <= budget) {
                Console.WriteLine($"You got this, {(budget - totalSum):F2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalSum - budget):F2} more!");
            }
        }
    }
}
