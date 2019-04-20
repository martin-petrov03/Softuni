using System;

namespace _03._Cat_Training_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double bonusPoints = 0;
            if (hourOfArrival >= startHour - 1 && hourOfArrival < startHour)
            {
                bonusPoints = 1.5;
            }
            else if (hourOfArrival == startHour && minutesOfArrival <= 30)
            {
                bonusPoints = 1;
            }
            else if ((hourOfArrival == startHour && minutesOfArrival > 30) || (hourOfArrival > startHour && hourOfArrival <= startHour + 4)) {
                bonusPoints = 0.5;
            }

            if (dayOfWeek == "Monday" || dayOfWeek == "Wednesday" || dayOfWeek == "Friday")
            {
                bonusPoints += 0.6;
            }
            else if (dayOfWeek == "Tuesday" || dayOfWeek == "Thursday" || dayOfWeek == "Saturday") {
                bonusPoints += 0.8;
            }
            else if (dayOfWeek == "Sunday")
            {
                bonusPoints += 2;
            }
            Console.WriteLine($"{bonusPoints:F2}");
        }
    }
}
