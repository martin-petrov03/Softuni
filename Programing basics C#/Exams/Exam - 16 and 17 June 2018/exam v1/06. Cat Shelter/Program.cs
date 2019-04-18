using System;

namespace _06._Cat_Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodQualityKg = double.Parse(Console.ReadLine());
            string command = string.Empty;

            double totalKg = 0;
            while (true) {
                command = Console.ReadLine();
                double kgPerEat = 0;
                if (command == "Adopted") {
                    if (foodQualityKg >= totalKg) {
                        Console.WriteLine($"Food is enough! Leftovers: {(foodQualityKg - totalKg) * 1000} grams.");
                    }
                    else
                    {
                        Console.WriteLine($"Food is not enough. You need {(totalKg - foodQualityKg) * 1000} grams more.");
                    }
                    break;
                }
                else
                {
                    kgPerEat = double.Parse(command);
                    kgPerEat /= 1000;
                    totalKg += kgPerEat;
                }
            }
        }
    }
}
