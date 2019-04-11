using System;

namespace _08.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";

            while ((destination = Console.ReadLine()) != "End") {
                double prise = double.Parse(Console.ReadLine());

                double savedMoneySum = 0;
                double savedMoney = 0;
                while (savedMoneySum < prise) {
                    savedMoney = double.Parse(Console.ReadLine());
                    savedMoneySum += savedMoney;
                }
                if(savedMoneySum >= prise)
                    Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}