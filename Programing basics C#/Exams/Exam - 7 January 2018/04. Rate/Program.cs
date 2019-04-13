using System;

namespace _04.Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double prise = double.Parse(Console.ReadLine());
            int countMonths = int.Parse(Console.ReadLine());

            double simpleInterest = 0;
            double complexInterest = 0;

            double interestPreviousMonth = prise;
            for (int i = 1; i <= countMonths; i++)
            {
                simpleInterest += prise * 3 / 100;
                complexInterest += interestPreviousMonth * 2.7 / 100.0;
                interestPreviousMonth = complexInterest;
                interestPreviousMonth += prise;
            }
            simpleInterest += prise;
            complexInterest += prise;
            double difference = Math.Max(simpleInterest, complexInterest) - Math.Min(complexInterest, simpleInterest);

            Console.WriteLine($"Simple interest rate: {simpleInterest:F2} lv.");
            Console.WriteLine($"Complex interest rate: {complexInterest:F2} lv.");
            if(simpleInterest > complexInterest)
                Console.WriteLine($"Choose a simple interest rate. You will win {difference:F2} lv.");
            else
                Console.WriteLine($"Choose a complex interest rate. You will win {difference:F2} lv.");
        }
    }
}