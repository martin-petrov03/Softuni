using System;

namespace _02.Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double foodForDayFirstDeer = double.Parse(Console.ReadLine());
            double foodForDaySecondDeer = double.Parse(Console.ReadLine());
            double foodForDayThirdDeer = double.Parse(Console.ReadLine());

            double firstDeerForAllDays = foodForDayFirstDeer * daysCount;
            double secondDeerForAllDays = foodForDaySecondDeer * daysCount;
            double thirdDeerForAllDays = foodForDayThirdDeer * daysCount;

            double allKgFood = firstDeerForAllDays + secondDeerForAllDays + thirdDeerForAllDays;
            if (allKgFood <= foodKg)
            {
                double kgResidue = foodKg - allKgFood;
                Console.WriteLine($"{Math.Floor(kgResidue)} kilos of food left.");
            }
            else {
                double kgLack = allKgFood - foodKg;
                Console.WriteLine($"{Math.Ceiling(kgLack)} more kilos of food are needed.");
            }
        }
    }
}