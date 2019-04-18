using System;

namespace _01._Cat_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double bedPrise = double.Parse(Console.ReadLine());
            double toiletPrise = double.Parse(Console.ReadLine());

            double foodPrise = toiletPrise + toiletPrise * 25 / 100;
            double playsPrise = foodPrise - foodPrise * 50 / 100;
            double doctorPrise = playsPrise + playsPrise * 10 / 100;
            double totalCostsForMonth = foodPrise + playsPrise + doctorPrise + toiletPrise;
            double otherCosts = totalCostsForMonth * 5 / 100;
            totalCostsForMonth += otherCosts;

            double totalPrise = 12 * totalCostsForMonth + bedPrise;
            Console.WriteLine($"{totalPrise:F2} lv.");
        }   
    }
}
