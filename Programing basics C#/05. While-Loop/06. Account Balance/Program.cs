using System;

namespace _06.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int installmentCount = int.Parse(Console.ReadLine());
            double totalBalance = 0;
            int i = 1;
            while (i <= installmentCount) {
                double currentInstallment = double.Parse(Console.ReadLine());
                if (currentInstallment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    totalBalance += currentInstallment;
                    Console.WriteLine($"Your account balance was increased by: {currentInstallment:f2}");
                }
                i++;
            }
            Console.WriteLine($"Total balance: {totalBalance:f2}");
        }
    }
}

