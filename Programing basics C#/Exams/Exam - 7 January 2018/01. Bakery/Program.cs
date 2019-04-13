using System;

namespace _01.Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal doughStart = decimal.Parse(Console.ReadLine());
            decimal oneItemWeight = decimal.Parse(Console.ReadLine());
            decimal oneItemPrice = decimal.Parse(Console.ReadLine());
            decimal itemsSold = decimal.Parse(Console.ReadLine());
            decimal sweetSold = decimal.Parse(Console.ReadLine());

            decimal dailyIncome = itemsSold * oneItemPrice;
            decimal doughBredNeeded = itemsSold * oneItemWeight;
            decimal outcomeDoughPrice = (doughStart + doughBredNeeded) / 250M;
            decimal sweetPrice = oneItemPrice + (oneItemPrice * 0.25M);
            decimal sweetWeight = oneItemWeight - (oneItemWeight * 0.2M);
            decimal sweetDough = sweetSold * sweetWeight;
            decimal sweetIncome = sweetSold * sweetPrice;
            decimal finalIncome = (dailyIncome + sweetIncome) - outcomeDoughPrice;
            decimal finalDough = doughBredNeeded + sweetDough;

            Console.WriteLine("Pure income: {0:0.00} lv.", finalIncome);
            Console.WriteLine($"Dough used: {(int)(Math.Ceiling(doughBredNeeded + sweetDough))} g.");
        }
    }
}