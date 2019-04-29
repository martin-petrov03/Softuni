using System;

namespace _1._Cherry_Jars
{
    class Program
    {
        static void Main(string[] args)
        {
            int kompotCount = int.Parse(Console.ReadLine());
            int marmaladeCount = int.Parse(Console.ReadLine());

            kompotCount += 1;
            marmaladeCount += 1;

            double qualityCherryForKompot = (kompotCount * 0.300) + (kompotCount * 0.300) * 5 / 100;
            double qualityCherryForMarmalade = (marmaladeCount * 0.650) + (marmaladeCount * 0.650) * 10 / 100;

            double totalQuality = qualityCherryForKompot + qualityCherryForMarmalade;
            double totalCherryPrise = totalQuality * 3.2;
            Console.WriteLine($"{totalCherryPrise:F2}");

        }
    }
}
