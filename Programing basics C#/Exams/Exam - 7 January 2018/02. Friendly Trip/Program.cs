using System;

namespace _02.Friendly_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            int litersBenzinForHundertKm = int.Parse(Console.ReadLine());
            double priseOneLiterBenzin = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double priseForBenzin = kilometers * litersBenzinForHundertKm / 100;
            priseForBenzin *= priseOneLiterBenzin;
         
            
            double difference = Math.Abs(priseForBenzin - budget); //разлика
            double forEach = budget / 5.0; //допълнително от всеки

            if (priseForBenzin <= budget)         
                Console.WriteLine($"You can take a trip. {difference:F2} money left.");
            else
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {forEach:F2} money.");
        }
    }
}