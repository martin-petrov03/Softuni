using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - 1.57
            double cpuDollarsPrise = double.Parse(Console.ReadLine());
            double videoChipDollarsPrise = double.Parse(Console.ReadLine());
            double ramDollarsPrise = double.Parse(Console.ReadLine());
            int ramsCount = int.Parse(Console.ReadLine());
            double prozents = double.Parse(Console.ReadLine());

            double cpuPriseLeva = cpuDollarsPrise * 1.57;
            double videoChipPriseLeva = videoChipDollarsPrise * 1.57;
            double ramPriseLeva = ramDollarsPrise * ramsCount * 1.57;

            cpuPriseLeva -= cpuPriseLeva * prozents;
            videoChipPriseLeva -= videoChipPriseLeva * prozents;

            double totalSum = cpuPriseLeva + videoChipPriseLeva + ramPriseLeva;
            Console.WriteLine($"Money needed - {totalSum:F2} leva.");
        }
    }
}
