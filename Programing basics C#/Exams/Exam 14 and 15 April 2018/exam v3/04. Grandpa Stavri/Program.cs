using System;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());

            double totalSum = 0;
            double totalLiters = 0;
            double previouslyDaySum = 0;
            for (int i = 1; i <= daysCount; i++)
            {
                double qualityRaki = double.Parse(Console.ReadLine());
                double currentRakiGradus = double.Parse(Console.ReadLine());
                totalLiters += qualityRaki;
                totalSum = previouslyDaySum + qualityRaki * currentRakiGradus;
                previouslyDaySum = previouslyDaySum + qualityRaki * currentRakiGradus;
            }

            double degrees = totalSum / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:F2}");
            Console.WriteLine($"Degrees: {degrees:F2}");
            if (degrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (degrees >= 38 && degrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else {

                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
