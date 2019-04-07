using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string preformanceType = Console.ReadLine().ToLower();
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());

            double incomeOfFullHall = 0;
            if (preformanceType == "premiere")
            {
                incomeOfFullHall = rowsCount * colsCount * 12;
            }
            else if (preformanceType == "normal")
            {
                incomeOfFullHall = rowsCount * colsCount * 7.5;
            }
            else if (preformanceType == "discount")
            {
                incomeOfFullHall = rowsCount * colsCount * 5;
            }
            else {
                Console.WriteLine("Error");
            }
            if (incomeOfFullHall > 0) {
                Console.WriteLine("{0:F2} leva", incomeOfFullHall);
            }

        }
    }
}