using System;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int secondsSum = time1 + time2 + time3;
            int min = secondsSum / 60;
            int sec = secondsSum - 60*min;
            //double minutesRes = secondsSum / 60;
            //double minutes = Math.Floor(minutesRes);
            //double seconds = secondsSum % 60;
            if (sec > 9)
            {
                Console.WriteLine($"{min}:{sec}");
            }
            else
            {    
                Console.Write($"{min}:0{sec}");               
            }
        }
    }
}