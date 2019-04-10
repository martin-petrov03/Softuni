using System;
using System.Globalization;
namespace _10.Days_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DateTime firstData = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime secondData = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    firstData = firstData.AddDays(1);
                }
                else {
                    secondData = secondData.AddDays(1);
                }
            }

            int sumOfDays = firstData.Day + secondData.Day;

            Console.WriteLine(sumOfDays);
        }
    }
}