using System;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoeKg = double.Parse(Console.ReadLine());
            int countBoxes = int.Parse(Console.ReadLine());
            int countJars = int.Parse(Console.ReadLine());

            double totalKgLutenica = tomatoeKg / 5;
            double jars = totalKgLutenica / 0.535;
            double boxes = jars / countJars;
            
            if (boxes >= countBoxes) {
                double remainingBoxes = boxes - countBoxes;
                double remainingJars = jars - (countBoxes * countJars);
                Console.WriteLine($"Total lutenica: {Math.Floor(totalKgLutenica)} kilograms.");
                Console.WriteLine($"{Math.Floor(remainingBoxes)} boxes left.");               
                Console.WriteLine($"{Math.Floor(remainingJars)} jars left.");
            } else {
                double remainingBoxes = countBoxes - boxes;
                double remainingJars = (countBoxes * countJars) - jars;
                Console.WriteLine($"Total lutenica: {Math.Floor(totalKgLutenica)} kilograms.");
                Console.WriteLine($"{Math.Floor(remainingBoxes)} more boxes needed.");
                Console.WriteLine($"{Math.Floor(remainingJars)} more jars needed.");
            }
        }
    }
}