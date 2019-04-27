using System;

namespace _3._Solar_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string planetName = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());

            double distance = 0;
            bool canHeStayInPlanetThisDays = false;
            if (planetName == "Mercury")
            {
                distance = 0.61;
                if (countDays <= 7) {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else if (planetName == "Venus")
            {
                distance = 0.28;
                if (countDays <= 14)
                {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else if (planetName == "Mars")
            {
                distance = 0.52;
                if (countDays <= 20)
                {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else if (planetName == "Jupiter")
            {
                distance = 4.2;
                if (countDays <= 5)
                {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else if (planetName == "Saturn")
            {
                distance = 8.52;
                if (countDays <= 3)
                {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else if (planetName == "Uranus")
            {
                distance = 18.21;
                if (countDays <= 3)
                {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else if (planetName == "Neptune")
            {
                distance = 29.09;
                if (countDays <= 2)
                {
                    canHeStayInPlanetThisDays = true;
                }
            }
            else {
                distance = -1;
            }

            if (distance == -1)
            {
                Console.WriteLine("Invalid planet name!");
            }
            else if (!canHeStayInPlanetThisDays || countDays < 1) {
                Console.WriteLine("Invalid number of days!");
            }
            else
            {
                double totalDistance = distance * 2;
                double days = 2 * (226 * distance) + countDays;

                Console.WriteLine($"Distance: {totalDistance:F2}");
                Console.WriteLine($"Total number of days: {days:F2}");
            }
        }
    }
}
