using System;

namespace _1._Mining_Rig
{
    class Program
    {
        static void Main(string[] args)
        {
            int videoChipPrise = int.Parse(Console.ReadLine());
            int adapterPrise = int.Parse(Console.ReadLine());
            double priseCurrentForOneCard = double.Parse(Console.ReadLine());
            double winOfOneCardForDay = double.Parse(Console.ReadLine());

            double totalSum = videoChipPrise * 13 + adapterPrise * 13 + 1000;
            double winForOneChip = winOfOneCardForDay - priseCurrentForOneCard;
            double totalWinForDay = winForOneChip * 13;

            Console.WriteLine(totalSum);
            Console.WriteLine((int)Math.Ceiling(totalSum / totalWinForDay));
        }
    }
}
