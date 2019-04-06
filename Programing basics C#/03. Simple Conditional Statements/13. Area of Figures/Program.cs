using System;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figurType = Console.ReadLine();
            if (figurType == "square") {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.Pow(a, 2), 3));
            }
            else if (figurType == "rectangle") {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * b), 3));
            }
            else if (figurType == "circle")
            {
                double r = double.Parse(Console.ReadLine());               
                Console.WriteLine(Math.Round((Math.PI * Math.Pow(r, 2)), 3));
            }
            else if (figurType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * h / 2), 3));
            }
        }
    }
}