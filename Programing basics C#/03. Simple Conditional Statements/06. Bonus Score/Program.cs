using System;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score: ");
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points <= 1000)
            {
                bonusPoints = 0.2 * points;
            }
            else if(points > 1000)
            {
                bonusPoints = 0.1 * points;
            }

            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            double totalScore = bonusPoints + points;
            Console.WriteLine($"Bonus score: {bonusPoints}");
            Console.WriteLine($"Total score: {totalScore}");
        }
    }
}