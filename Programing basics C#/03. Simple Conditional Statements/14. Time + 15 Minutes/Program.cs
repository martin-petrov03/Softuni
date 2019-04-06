using System;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            if (seconds + 15 >= 60)
            {
                if (hours == 23)
                {
                    hours = 0;
                }
                else
                {
                    hours += 1;
                }
                seconds = Math.Abs(60 - seconds - 15);
                if (seconds < 10)
                {                    
                    Console.WriteLine($"{hours}:0{Math.Abs(seconds)}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{Math.Abs(seconds)}");
                }
            }
            else {
                seconds += 15;
                if (seconds < 10)
                {
                    Console.WriteLine($"{hours}:0{Math.Abs(seconds)}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{Math.Abs(seconds)}");
                }
            }
        }
    }
}