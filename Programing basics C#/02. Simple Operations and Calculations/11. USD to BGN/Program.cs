using System;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549 * Usd;
            Console.WriteLine(bgn);
        }
    }
}a