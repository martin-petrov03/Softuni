using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int countWeekendsForVolleyball = int.Parse(Console.ReadLine());
            int countWeekendsForTravel = int.Parse(Console.ReadLine());

            int sumOfWeekends = countWeekendsForVolleyball + countWeekendsForTravel;
            if (typeYear == "leap")
            {
                double wekkendsWithoutTravel = (48 - countWeekendsForTravel);
                double weekendsInSofiaWithVolleyball = wekkendsWithoutTravel * 3 / 4d;
                //Console.WriteLine($"{weekendsInSofiaWithVolleyball:F7}");
                double weekendsInHomeTown = countWeekendsForTravel;
                //Console.WriteLine($"{weekendsInHomeTown:F7}");
                double playsInHolidays = countWeekendsForVolleyball * 2 / 3d;
                //Console.WriteLine($"{playsInHolidays:F7}");
                double bonusPlays = 15 / 100d * (playsInHolidays + weekendsInHomeTown + weekendsInSofiaWithVolleyball);
                //Console.WriteLine($"{bonusPlays:F7}");
                double allPlayTimes = weekendsInSofiaWithVolleyball + bonusPlays + weekendsInHomeTown + playsInHolidays;

                Console.WriteLine(Math.Floor(allPlayTimes));
            }
            else if (typeYear == "normal") {
               double weekendsInSofiaWithVolleyball = (48 - countWeekendsForTravel) * 3 / 4d;
                double weekendsInHomeTown = countWeekendsForTravel;
                double playsInHolidays = countWeekendsForVolleyball * 2 / 3d;
                double allPlayTimes = weekendsInSofiaWithVolleyball + weekendsInHomeTown + playsInHolidays;

                Console.WriteLine(Math.Floor(allPlayTimes));
            }
        }
    }
}