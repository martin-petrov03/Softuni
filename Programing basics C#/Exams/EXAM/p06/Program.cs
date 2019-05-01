using System;

namespace p06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isBreak = false;
            for (char a = 'B'; a <= 'L'; a++)
            {
                if (a % 2 == 0)
                {
                    for (char b = 'f'; b >= 'a'; b--)
                    {
                        for (char c = 'A'; c <= 'C'; c++)
                        {
                            for (int d = 1; d <= 10; d++)
                            {
                                for (int i = 10; i >= 1; i--)
                                {

                                    counter++;
                                    if (counter == n)
                                    {
                                        int sum = (int)a + (int)b + (int)c + d + i;
                                        Console.WriteLine($"Ticket combination: {a}{b}{c}{d}{i}");

                                        Console.WriteLine($"Prize: {sum} lv.");
                                        //isBreak = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
