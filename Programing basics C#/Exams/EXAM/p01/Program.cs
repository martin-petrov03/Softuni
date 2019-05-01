using System;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrise = double.Parse(Console.ReadLine());

            double moneyForOneSector = (capacity * ticketPrise) / countSectors;
            double sumAllSectors = moneyForOneSector * countSectors;
            double charity = (sumAllSectors - (moneyForOneSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {sumAllSectors:F2} BGN");
            Console.WriteLine($"Money for charity - {charity:F2} BGN");
        } 
    }
}
