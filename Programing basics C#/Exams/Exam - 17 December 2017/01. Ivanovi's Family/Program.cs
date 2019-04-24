using System;

namespace _01.Ivanovi_s_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstChildPresentPrise = double.Parse(Console.ReadLine());
            double secondChildPresentPrise = double.Parse(Console.ReadLine());
            double thirdtChildPresentPrise = double.Parse(Console.ReadLine());

            double sum = firstChildPresentPrise + secondChildPresentPrise + thirdtChildPresentPrise;
            double totalSum = (budget - sum) - (budget - sum) * 10 / 100;
            
           // double totalSum = budget - sumWithoutTax;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}