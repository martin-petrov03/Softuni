using System;

namespace _01.Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int breakMinutes = int.Parse(Console.ReadLine());
            double packetCardsPrise = double.Parse(Console.ReadLine());
            double adventurePrise = double.Parse(Console.ReadLine());
            double coffeePrise = double.Parse(Console.ReadLine());

            int breakMinutesWithoutCoffeTime = breakMinutes - 5;
            int timeForCards = 3 * 2;
            int timeForAdventure = 2 * 2;
            
            int remainingTime = breakMinutesWithoutCoffeTime - (timeForCards + timeForAdventure);
            double moneyForPacks = 3 * packetCardsPrise;
            double moneyForAdventure = 2 * adventurePrise;

            double allSpentMoney = moneyForPacks + moneyForAdventure + coffeePrise;

            Console.WriteLine($"{allSpentMoney:F2}");
            Console.WriteLine($"{remainingTime}");
        }
    }
}
//start  -> 21:46
//end    -> 22.03