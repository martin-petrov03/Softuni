using System;

namespace _04._Running_In_The_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());

            int totalMinutes = 0;
            double totalDistanceKilometers = 0;
            int totalCallories = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                int minutes = int.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                string distanceType = Console.ReadLine();

                int calorries = minutes * 20;
                totalCallories += calorries;

                totalMinutes += minutes;

                if (distanceType == "m")
                {
                    totalDistanceKilometers += distance / 1000;
                }
                else if (distanceType == "km") {
                    totalDistanceKilometers += distance;
                }
            }
            Console.WriteLine($"He ran {totalDistanceKilometers:F2}km for {totalMinutes} minutes and burned {totalCallories} calories.");
        }
    }
}
