using System;

namespace _01.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double priseForOneMeter = double.Parse(Console.ReadLine());
            double weightForOneMeter = double.Parse(Console.ReadLine());

            double perimeter = 2 * a + 2 * b;
            double prise = perimeter * priseForOneMeter;
            double area = h * perimeter;
            double weight = area * weightForOneMeter;

            Console.WriteLine($"{perimeter}");
            Console.WriteLine($"{prise:F2}");           
            Console.WriteLine($"{weight:F3}");
        }
    }
}