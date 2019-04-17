using System;

namespace _03._Arena_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPoints = int.Parse(Console.ReadLine());
            string arenaType = Console.ReadLine();
            string day = Console.ReadLine();
            string condition = Console.ReadLine();

            double prise = 0;
            double discount = 0;
            if (arenaType == "Nagrand") {
                if (condition == "Poor") {
                    prise = 7000;
                    if (day == "Monday" || day == "Wednesday") { discount = 5; }
                }
                else if (condition == "Normal")
                {
                    prise += 14000;
                    if (day == "Monday" || day == "Wednesday") { discount = 5; }
                }
                else if (condition == "Legendary")
                {
                    prise = 21000;
                    if (day == "Monday" || day == "Wednesday") { discount = 5; }
                }
            }
            else if (arenaType == "Gurubashi")
            {
                if (condition == "Poor")
                {
                    prise = 7000;
                    if (day == "Tuesday" || day == "Thursday") { discount = 10; }
                }
                else if (condition == "Normal")
                {
                    prise = 14000;
                    if (day == "Tuesday" || day == "Thursday") { discount = 10; }
                }
                else if (condition == "Legendary")
                {
                    prise = 21000;
                    if (day == "Tuesday" || day == "Thursday") { discount = 10; }
                }
            }
            else if (arenaType == "Dire Maul")
            {
                if (condition == "Poor")
                {
                    prise = 7000;
                    if (day == "Friday" || day == "Saturday") { discount = 7; }
                }
                else if (condition == "Normal")
                {
                    prise = 14000;
                    if (day == "Friday" || day == "Saturday") { discount = 7; }
                }
                else if (condition == "Legendary")
                {
                    prise = 21000;
                    if (day == "Friday" || day == "Saturday") { discount = 7; }
                }                
            }
            //double priseWithoutDiscount = prise;
            prise -= prise * discount / 100;

            double oneItemPrise = prise / 5;
            int countBougthItems = 0;
            double currentSum = countPoints;
            for (int i = 1; i <= 5; i++)
            {
                currentSum -= oneItemPrise;
                if (currentSum < 0)
                {
                    currentSum += oneItemPrise;
                    break;
                }
                else {
                    countBougthItems++;
                }
            }
            if (countBougthItems == 5)
            {
                Console.WriteLine($"Items bought: {countBougthItems}");
                Console.WriteLine($"Arena points left: {currentSum}");
                Console.WriteLine($"Success!");
            }
            else {
                Console.WriteLine($"Items bought: {countBougthItems}");
                Console.WriteLine($"Arena points left: {currentSum}");
                Console.WriteLine($"Failure!");
            }
        }
    }
}