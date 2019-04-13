using System;

namespace _01.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double priseOfKiloSand = double.Parse(Console.ReadLine());
            double priseOfOneBoard = double.Parse(Console.ReadLine());
            
            double area = width * heigth;
            double areaSandBox = (width - (0.2 + 0.2)) * (heigth - (0.2 + 0.2));
            double areaCurbs = area - areaSandBox;
            double quantitySand = Math.Ceiling(areaSandBox * 20);
            double boards = Math.Ceiling(areaCurbs / (2.2 * 0.2));
            double boardsPrise = priseOfOneBoard * boards;
            double sandPrise = quantitySand * priseOfKiloSand;

            double sum = boardsPrise + sandPrise;
            Console.WriteLine($"{sum:F2}");
        }
    }
}