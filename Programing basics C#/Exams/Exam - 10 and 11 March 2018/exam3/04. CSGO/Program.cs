using System;

namespace _04._CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            int countItems = int.Parse(Console.ReadLine());
            if (countItems > 7)
            {
                Console.WriteLine($"Sorry, you can't carry so many things!");
            }
            else
            {
                double budget = double.Parse(Console.ReadLine());

                double neededMoney = 0;
                for (int i = 1; i <= countItems; i++)
                {
                    string currentWeopan = Console.ReadLine();
                    if (currentWeopan == "ak47")
                    {
                        neededMoney += 2700;
                    }
                    else if (currentWeopan == "awp")
                    {
                        neededMoney += 4750;
                    }
                    else if (currentWeopan == "sg553")
                    {
                        neededMoney += 3500;
                    }
                    else if (currentWeopan == "grenade")
                    {
                        neededMoney += 300;
                    }
                    else if (currentWeopan == "flash")
                    {
                        neededMoney += 250;
                    }
                    else if (currentWeopan == "glock")
                    {
                        neededMoney += 500;
                    }
                    else if (currentWeopan == "bazooka")
                    {
                        neededMoney += 5600;
                    }
                }

                if (neededMoney <= budget)
                {
                    Console.WriteLine($"You bought all {countItems} items! Get to work and defeat the bomb!");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {neededMoney - budget} more money.");
                }
            }
        }
    }
}
//1h 54 min