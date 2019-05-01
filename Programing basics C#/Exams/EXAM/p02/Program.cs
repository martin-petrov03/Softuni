using System;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            double beerPrise = 1.2;

            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beerBottlesCount = double.Parse(Console.ReadLine());
            double chipsCount = double.Parse(Console.ReadLine());

            double beerTotalPrise = beerBottlesCount * 1.2;
            double oneChipsPrise = beerTotalPrise * 45 / 100.0;
            double chipsTotalPrise = Math.Ceiling(oneChipsPrise * chipsCount);

            double totalPrise = beerTotalPrise + chipsTotalPrise;

            if (budget >= totalPrise)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - totalPrise):F2} money left.");
            }
            else {
                Console.WriteLine($"{name} needs {(totalPrise - budget):F2} more money!");
            }
        }
    }
}
