using System;

namespace _01._Programming_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            double onePagePrise = double.Parse(Console.ReadLine());
            double coverPrise = double.Parse(Console.ReadLine());
            int prozentDiscount = int.Parse(Console.ReadLine());
            double disignPrise = double.Parse(Console.ReadLine()); 
            int prozentTeamCost = int.Parse(Console.ReadLine());

            double totalSum = 899 * onePagePrise + 2 * coverPrise;
            totalSum -= totalSum * prozentDiscount / 100;
            totalSum += disignPrise;
            totalSum -= totalSum * prozentTeamCost / 100;
            Console.WriteLine($"Avtonom should pay {totalSum:F2} BGN.");
        }
    }
}
