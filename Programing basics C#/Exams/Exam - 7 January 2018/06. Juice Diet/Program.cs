using System;

namespace _06.Juice_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int rasperry = int.Parse(Console.ReadLine());
            int strawberry = int.Parse(Console.ReadLine());
            int cherry = int.Parse(Console.ReadLine());
            double maxMl = double.Parse(Console.ReadLine());

            double rasperryMl = 4.5 * rasperry;
            double strawberryMl = 7.5 * strawberry;
            double cherryMl = 15 * cherry;

            double total = 0.0;

            int cherryUsed = 0;
            int strawUsed = 0;
            int raspUsed = 0;

          //  double totall = 0;
            for (int i = 0; i <= cherry; i++)
            {
                for (int j = 0; j <= strawberry; j++)
                {
                    for (int k = 0; k <= rasperry; k++)
                    {
                        double ml = k * 15 + j * 7.5 + i * 4.5;                       
                        if (ml <= maxMl)
                        {
                            if (ml > total)
                            {
                                total = ml;
                            }
                            if (ml >= total)
                            {
                                cherryUsed = i;
                                strawUsed = j;
                                raspUsed = k;
                            }
                        }
                    }
                }

            }
            //totall = raspUsed * 4.5 + strawUsed * 7.5 + cherryUsed * 15;
            Console.WriteLine($"{raspUsed} Raspberries, {strawUsed} Strawberries, {cherryUsed} Cherries. Juice: {total} ml.");
        }
    }
}