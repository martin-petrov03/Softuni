using System;

namespace _2._AND_Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cpuCount = decimal.Parse(Console.ReadLine());
            int staffsCount = int.Parse(Console.ReadLine());
            int workedDays = int.Parse(Console.ReadLine());

            int hoursWork = 8 * workedDays * staffsCount;
            int makedCpuCOunt = hoursWork / 3;
            if (makedCpuCOunt >= cpuCount)
            {
                double profits = (makedCpuCOunt - (double)cpuCount) * 110.10;
                Console.WriteLine($"Profit: -> {profits:F2} BGN");
            }
            else {
                double losts = ((double)cpuCount - makedCpuCOunt) * 110.10;                
                Console.WriteLine($"Losses: -> {losts:F2} BGN");
            }
        }
    }
}
