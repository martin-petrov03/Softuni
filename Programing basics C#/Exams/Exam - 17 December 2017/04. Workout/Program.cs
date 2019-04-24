using System;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            double firstDayKilometers = double.Parse(Console.ReadLine());

            double totalKilometers = firstDayKilometers;
            double kilometersPreviosDay = firstDayKilometers;
            for (int i = 1; i <= countDays; i++)
            {
                int prozentPlus = int.Parse(Console.ReadLine());               
                double kilometersThisDay =  kilometersPreviosDay + kilometersPreviosDay * prozentPlus / 100;
                //Console.WriteLine(kilometersThisDay);
                totalKilometers += kilometersThisDay;
                kilometersPreviosDay = kilometersThisDay;
            }
            
            if (totalKilometers >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKilometers - 1000)} more kilometers!");
            }
            else {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKilometers)} more kilometers");
            }
        }
    }
}