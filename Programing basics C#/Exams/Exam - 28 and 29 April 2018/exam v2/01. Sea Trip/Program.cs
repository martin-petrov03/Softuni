using System;

namespace _01._Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodPrise = double.Parse(Console.ReadLine());
            double souvenirsPrise = double.Parse(Console.ReadLine());
            double hotelPrise = double.Parse(Console.ReadLine());

            double totalMoneyForHotel = (hotelPrise - hotelPrise * 0.1) + (hotelPrise - hotelPrise * 0.15) + (hotelPrise - hotelPrise * 0.2);
            double moneyForCar = 54.39;
            double totalPrise = foodPrise * 3 + souvenirsPrise * 3 + totalMoneyForHotel + moneyForCar;
            Console.WriteLine($"Money needed: {totalPrise:F2}");
        }
    }
}
