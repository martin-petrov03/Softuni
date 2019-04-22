using System;

namespace _03.Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int daysCount = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();
            
            int nights = daysCount - 1;
            double priseLv = 0;
            double discount = 0;

            if (roomType == "room for one person")
            {
                priseLv = 18 * nights;
            }
            else if (roomType == "apartment")
            {
                if (daysCount > 0 && daysCount < 10) {
                    discount = 30;
                } else if (daysCount >= 10 && daysCount <= 15)
                {
                    discount = 35;
                }else if(daysCount > 15)
                {
                    discount = 50;
                }
                priseLv = 25 * nights;
            }
            else if (roomType == "president apartment") {
                if (daysCount > 0 && daysCount < 10)
                {
                    discount = 10;
                }
                else if (daysCount >= 10 && daysCount <= 15)
                {
                    discount = 15;
                }
                else if (daysCount > 15)
                {
                    discount = 20;
                }
                priseLv = 35 * nights;
            }
            priseLv -= priseLv * discount / 100;
            if (evaluation == "positive")
            {
                priseLv += priseLv * 25 / 100;
            }
            else if (evaluation == "negative") {
                priseLv -= priseLv * 10 / 100;
            }            
            Console.WriteLine($"{priseLv:F2}");
        }
    }
}