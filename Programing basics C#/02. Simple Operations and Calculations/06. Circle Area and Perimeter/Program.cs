using System;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * r * Math.PI;
            double area = r * r * Math.PI;

            Console.WriteLine($"Area = {area:F4}");
            Console.WriteLine($"Perimeter = {perimeter:F4}");
        }
    }
}