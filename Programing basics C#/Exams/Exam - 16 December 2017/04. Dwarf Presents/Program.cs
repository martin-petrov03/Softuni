using System;

namespace _04.Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gnomsCount = int.Parse(Console.ReadLine());
            int maxPrise = int.Parse(Console.ReadLine());
            string souvenirType;

            double clockQuality = 0;
            double magnetQuality = 0;
            double cupQuality = 0;
            double tShirtQuality = 0;

            double sum = 0;
            int i = 1;
            while (i <= gnomsCount)
            {
                souvenirType = Console.ReadLine();
                if (souvenirType == "sand clock")
                {
                    clockQuality++;
                    sum += 2.2;
                }
                else if (souvenirType == "magnet")
                {
                    magnetQuality++;
                    sum += 1.5;
                }
                else if (souvenirType == "cup")
                {
                    cupQuality++;
                    sum += 5;
                }
                else if (souvenirType == "t-shirt")
                {
                    tShirtQuality++;
                    sum += 10;
                }
                i++;
            }
            if (sum <= maxPrise)
            {
                //Console.WriteLine(sum);
                double redueceMoney = maxPrise - sum;
                Console.WriteLine($"Santa Claus has {redueceMoney:F2} more leva left!");
            }
            else {
                //Console.WriteLine(sum);
                double moneyLack = sum - maxPrise;
                Console.WriteLine($"Santa Claus will need {moneyLack:F2} more leva.");
            }
        }
    }
}