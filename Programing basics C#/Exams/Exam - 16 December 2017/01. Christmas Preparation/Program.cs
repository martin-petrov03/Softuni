using System;

namespace _01.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollerPaperCount = int.Parse(Console.ReadLine());
            int rollerFabrikCount = int.Parse(Console.ReadLine());
            double glueLitersCount = double.Parse(Console.ReadLine());
            int prozentReduction = int.Parse(Console.ReadLine());

            double priseRollerPaperCount = rollerPaperCount * 5.8;
            double priseRollerFabrikCount = rollerFabrikCount * 7.2;
            double priseGlueLitersCount = glueLitersCount * 1.2;

            double totalSum = priseRollerPaperCount + priseRollerFabrikCount + priseGlueLitersCount;
            double reduction = totalSum * prozentReduction / 100;
            totalSum -= reduction;
            Console.WriteLine($"{totalSum:F3}");
        }
    }
}