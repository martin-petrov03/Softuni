using System;

namespace _02.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine($"Centimeters = {centimeters:F2}");
        }
    }
}