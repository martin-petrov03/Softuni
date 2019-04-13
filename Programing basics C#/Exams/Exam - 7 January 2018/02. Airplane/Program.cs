using System;

namespace _02.Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());

            int minutesPlus = duration + minutes;
            while (minutesPlus >= 60) {
                hour += 1;
                minutesPlus -= 60;
            }
            if (hour >= 24) {
                hour = 0 + hour - 24;
            }
            Console.WriteLine($"{hour}h {minutesPlus}m");
        }
    }
}