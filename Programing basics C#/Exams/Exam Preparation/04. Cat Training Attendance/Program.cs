using System;

namespace _04._Cat_Training_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int boughtFoodKg = int.Parse(Console.ReadLine());
            string command = string.Empty;

            int boughtFoodGramms = boughtFoodKg * 1000;

            int totalGrammsAteFood = 0;
            while ((command = Console.ReadLine()) != "Adopted") {
                int grammsFood = int.Parse(command);
                totalGrammsAteFood += grammsFood;
            }

            if (totalGrammsAteFood <= boughtFoodGramms)
            {
                Console.WriteLine($"Food is enough! Leftovers: {(boughtFoodGramms - totalGrammsAteFood)} grams.");
            }
            else {
                Console.WriteLine($"Food is not enough. You need {(totalGrammsAteFood - boughtFoodGramms)} grams more.");
            }
        }
    }
}
