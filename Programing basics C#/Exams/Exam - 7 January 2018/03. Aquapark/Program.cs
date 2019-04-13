using System;

namespace _03.Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int hours = int.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());
            string dayType = Console.ReadLine().ToLower();

            double sumPerPerosn = 0;
            if (month == "march" || month == "april" || month == "may") {
                if(dayType == "day")
                    sumPerPerosn = 10.50;
                else
                    sumPerPerosn = 8.40;
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (dayType == "day")
                    sumPerPerosn = 12.60;
                else
                    sumPerPerosn = 10.20;
            }
            if (hours >= 5)
                sumPerPerosn -= sumPerPerosn * 50 / 100.0;
            if (countPeople >= 4)
                sumPerPerosn -= sumPerPerosn * 10 / 100.0;
            Console.WriteLine($"Price per person for one hour: {sumPerPerosn:F2}");
            Console.WriteLine($"Total cost of the visit: {(countPeople * sumPerPerosn * hours):F2}");
        }
    }
}