using System;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int countMatches = int.Parse(Console.ReadLine());

            int minutesAllMatchesSum = 0;
            int countMatchesWithPenalties = 0;
            int countMatchesWithAdditionalTime = 0;
            for (int i = 1; i <= countMatches; i++)
            {
                int minutesTime = int.Parse(Console.ReadLine());
                minutesAllMatchesSum += minutesTime;
                if (minutesTime > 90) {
                    countMatchesWithAdditionalTime++;
                    if (minutesTime > 120) {
                        countMatchesWithPenalties++;
                    }
                }
            }
            double average = (double)minutesAllMatchesSum / countMatches;
            Console.WriteLine($"{team} has played {minutesAllMatchesSum} minutes. Average minutes per game: {average:F2}");
            Console.WriteLine($"Games with penalties: {countMatchesWithPenalties}");
            Console.WriteLine($"Games with additional time: {countMatchesWithAdditionalTime - countMatchesWithPenalties}");
        }
    }
}
