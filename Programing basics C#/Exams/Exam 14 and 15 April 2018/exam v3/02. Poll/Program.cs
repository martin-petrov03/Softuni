using System;

namespace _2._Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int votesForFirstLanguages = int.Parse(Console.ReadLine());

            double votesForSecondLanguages = votesForFirstLanguages - votesForFirstLanguages * 20 / 100d;
            double votesForThirdLanguages = votesForSecondLanguages - votesForSecondLanguages * 10 / 100d;

            double votesForFirstThreeLangugages = votesForFirstLanguages + votesForSecondLanguages + votesForThirdLanguages;

            if (votesForFirstThreeLangugages >= people / 2)
            {
                Console.WriteLine($"First three languages have {Math.Ceiling(votesForFirstThreeLangugages - people / 2)} votes more");
            }
            else {
                Console.WriteLine($"First three languages have {Math.Ceiling(people / 2 - votesForFirstThreeLangugages)} votes less of half votes");
            }

        }
    }
}
