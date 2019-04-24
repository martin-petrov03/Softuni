using System;

namespace _02.New_Years_Eve_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double priseForGuests = guestsCount * 20;
            if (priseForGuests < budget)
            {
                //double remainingMoney = budget - priseForGuests;
                double fireworksPrise = (budget - priseForGuests) * 40 / 100;                
                double donation = budget - (priseForGuests + fireworksPrise);
                Console.WriteLine($"Yes! {Math.Round(fireworksPrise)} lv are for fireworks and {Math.Round(donation)} lv are for donation.");
            }
            else if (priseForGuests < budget) {                                                
                Console.WriteLine($"Yes! {0} lv are for fireworks and {0} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Abs(Math.Round(budget - priseForGuests))} lv more.");
            }
        }
    }
}