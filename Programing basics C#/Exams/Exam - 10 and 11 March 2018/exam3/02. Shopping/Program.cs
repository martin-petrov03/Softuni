using System;

namespace _02._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int chocolateCount = int.Parse(Console.ReadLine());
            double milkLiteers = double.Parse(Console.ReadLine());

            double chocoPrise = 0.65 * chocolateCount;
            double milkPrise = Math.Round(milkLiteers * 2.7, 2);
            int mandariniCount = chocolateCount - (int)Math.Ceiling(chocolateCount * 0.35);
            double mandariniPrise = Math.Round(mandariniCount * 0.2, 2);
            //double mandariniPrise = (chocolateCount - (chocolateCount * 0.35)) * 0.2;
            double totalSum = chocoPrise + milkPrise + mandariniPrise;
            if (totalSum <= budget)
            {
                Console.WriteLine($"You got this, {(budget - totalSum):F2} money left!");
            }
            else {
                Console.WriteLine($"Not enough money, you need {(totalSum - budget):F2} more!");
            }
        }
    }
}
// start -> 5:07