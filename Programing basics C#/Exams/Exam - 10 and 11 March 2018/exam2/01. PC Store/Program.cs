using System;

namespace _01.PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuDollarPrise = double.Parse(Console.ReadLine());
            double videoChipDollarPrise = double.Parse(Console.ReadLine());
            double ramChipDollarPrise = double.Parse(Console.ReadLine());
            int countRamChips = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuLevaPrise = cpuDollarPrise * 1.57;
            double videoChipLevaPrise = videoChipDollarPrise * 1.57;
            double ramChipLevaPrise = ramChipDollarPrise * 1.57 * countRamChips;

            cpuLevaPrise -= cpuLevaPrise * discount;
            videoChipLevaPrise -= videoChipLevaPrise * discount;

            double totalSum = cpuLevaPrise + videoChipLevaPrise + ramChipLevaPrise;
            Console.WriteLine($"Money needed - {totalSum:F2} leva.");
        }
    }
}
//start  ->  10:24
//break  -> 10:28 - 10:30
//end  ->  10:31