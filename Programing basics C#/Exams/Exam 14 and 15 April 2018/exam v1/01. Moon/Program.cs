using System;

namespace _1._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = 384400;
            int hoursBreak = 3;

            double speed = double.Parse(Console.ReadLine());
            double fuelFor100Km = double.Parse(Console.ReadLine());

            double totalTime = (384400 * 2) / speed;
            totalTime = Math.Ceiling(totalTime);
            totalTime += 3;

            double totalFuel = (fuelFor100Km * 384400 * 2) / 100;

            Console.WriteLine($"{totalTime:F0}");
            Console.WriteLine($"{totalFuel}");
        }
    }
}
