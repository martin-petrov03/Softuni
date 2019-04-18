using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsCount = int.Parse(Console.ReadLine());

            int groupSmallCats = 0;
            int groupBigCats = 0;
            int groupUltraBigCats = 0;
            double totalGramms = 0;
            for (int i = 1; i <= catsCount; i++)
            {
                double gramms = double.Parse(Console.ReadLine());
                                
                if (gramms >= 100 && gramms < 200) {
                    groupSmallCats++;
                    totalGramms += gramms;
                }
                else if (gramms >= 200 && gramms < 300)
                {
                    groupBigCats++;
                    totalGramms += gramms;
                }
                else if (gramms >= 300 && gramms < 400)
                {
                    groupUltraBigCats++;
                    totalGramms += gramms;
                }
            }
            double price = totalGramms / 1000;
            price *= 12.45;

            Console.WriteLine($"Group 1: {groupSmallCats} cats.");
            Console.WriteLine($"Group 2: {groupBigCats} cats.");
            Console.WriteLine($"Group 3: {groupUltraBigCats} cats.");
            Console.WriteLine($"Price for food per day: {Math.Round(price, 2)} lv.");
        }
    }
}
