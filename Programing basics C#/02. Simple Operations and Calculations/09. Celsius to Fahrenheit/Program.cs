using System;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsium = double.Parse(Console.ReadLine());
            double fahrenheitDegres = celsium * 1.8 + 32;
            Console.WriteLine(fahrenheitDegres);
        }
    }
}