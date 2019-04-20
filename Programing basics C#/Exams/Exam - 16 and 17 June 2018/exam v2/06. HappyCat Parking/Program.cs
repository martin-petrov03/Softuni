using System;

namespace _06._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int countHoursForEveryDay = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int currentDay = 1; currentDay <= countDays; currentDay++)
            {
                double thisDaySum = 0;
                for (int currentHour = 1; currentHour <= countHoursForEveryDay; currentHour++)
                {
                    if (currentDay % 2 == 0 && currentHour % 2 != 0)
                    {
                        thisDaySum += 2.5;
                    }
                    else if (currentDay % 2 != 0 && currentHour % 2 == 0)
                    {
                        thisDaySum += 1.25;
                    }
                    else {
                        thisDaySum += 1;
                    }
                }
                Console.WriteLine($"Day: {currentDay} - {thisDaySum:F2} leva");
                sum += thisDaySum;
            }
            Console.WriteLine($"Total: {sum:F2} leva");
        }
    }
}
