using System;

namespace _03.Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double priseForOneKm = 0;
            if (type == "standard")
            {
                if (weight < 1)
                {
                    priseForOneKm = 3;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    priseForOneKm = 5;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    priseForOneKm = 10;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    priseForOneKm = 15;
                }
                else if (weight >= 91)
                {
                    priseForOneKm = 20;
                }
                Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {(priseForOneKm / 100 * distance):F2} lv.");
            }
            else if (type == "express")
            {
                if (weight < 1)
                {
                    priseForOneKm = distance * 0.03 + 0.03 * 0.8 * weight * distance;
                }
                else if (weight >= 1 && weight <= 10)
                {
                    priseForOneKm = distance * 0.05 + 0.05 * 0.4 * weight * distance;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    priseForOneKm = distance * 0.1 + 0.1 * 0.05 * weight * distance;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    priseForOneKm = distance * 0.15 + 0.15 * 0.02 * weight * distance;
                }
                else if (weight >= 91)
                {                   
                    priseForOneKm = distance * 0.20 + 0.20 * 0.01 * weight * distance;
                }
    
                Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {priseForOneKm:F2} lv.");
            } else {
                Console.WriteLine("error");
            }
        }
    }
}