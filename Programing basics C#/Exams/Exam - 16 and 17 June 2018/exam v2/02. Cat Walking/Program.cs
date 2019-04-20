using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int countWalks = int.Parse(Console.ReadLine());
            int collectedCalloriesForThisDay = int.Parse(Console.ReadLine());

            int totalBurnedCallories = countWalks * minutesWalk * 5;

            if (totalBurnedCallories >= 50 / 100.0 * collectedCalloriesForThisDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalBurnedCallories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalBurnedCallories}.");
            }
        }
    }
}
