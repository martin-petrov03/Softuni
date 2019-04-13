using System;

namespace _06.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            // 2 / 1 / 0.50 / 0.20 / 0.10 / 0.05 / 0.02 / 0.01
            int countTimes = 0;
            while (balance >= 2) {
                balance -= 2;
                countTimes++;
            }
            while (balance >= 1)
            {
                balance -= 1;
                countTimes++;
            }
            while (balance >= (decimal) 0.5)
            {
                balance -= 0.5m;
                countTimes++;
            }
            while (balance >= 0.2m)
            {
                balance -= 0.2m;
                countTimes++;
            }
            while (balance >= 0.1m)
            {
                balance -= 0.1m;
                countTimes++;
            }
            while (balance >= 0.05m)
            {
                balance -= 0.05m;
                countTimes++;
            }
            while (balance >= 0.02m)
            {
                balance -= 0.02m;
                countTimes++;
            }
            while (balance >= 0.01m)
            {
                balance -= 0.01m;
                countTimes++;
            }
            Console.WriteLine(countTimes);
        }
    }
}