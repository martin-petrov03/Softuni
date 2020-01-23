using System;

namespace _04.HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
            .Split();
            PriceCalculator priceCalculator = new PriceCalculator(input);            
            Console.WriteLine($"{priceCalculator.GetTotalPrice():f2}");
        }        
    }
}