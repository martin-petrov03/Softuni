using System;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int countMatches = int.Parse(Console.ReadLine());

            int sumTotalPoints = 0;
            int scoredGoalsSum = 0;
            int havenGoalsSum = 0;
            int goalsDifferenceSums = 0;
            for (int i = 1; i <= countMatches; i++)
            {
                int scoreGoals = int.Parse(Console.ReadLine());
                int havenGoals = int.Parse(Console.ReadLine());

                scoredGoalsSum += scoreGoals;
                havenGoalsSum += havenGoals;

                int currentPoints = 0;
                if (scoreGoals > havenGoals)
                {
                    currentPoints = 3;
                    goalsDifferenceSums += scoreGoals - havenGoals;
                }
                else if (scoreGoals == havenGoals)
                {
                    currentPoints = 1;
                    goalsDifferenceSums += scoreGoals - havenGoals;
                }
                else {
                    currentPoints = 0;
                    goalsDifferenceSums += scoreGoals - havenGoals;
                }             
                sumTotalPoints += currentPoints;
            }

            if (scoredGoalsSum >= havenGoalsSum)
            {
                Console.WriteLine($"{team} has finished the group phase with {sumTotalPoints} points.");
                Console.WriteLine($"Goal difference: {goalsDifferenceSums}.");
            }
            else {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalsDifferenceSums}.");
            }
        }
    }
}
