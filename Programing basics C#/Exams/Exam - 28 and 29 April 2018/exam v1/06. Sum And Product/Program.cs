using System;

namespace _06._Sum_And_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = String.Empty;
            bool isBreak = false;

            for (int a = 1; a <= 9; a++)
            {                              
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            int sum = a + b + c + d;
                            int multiply = a * b * c * d;

                            int deciline = multiply / sum;
                            if (sum == multiply && n % 10 == 5)
                            {
                                result = $"{a}{b}{c}{d}";
                                isBreak = true;
                                break;
                            }
                            else if ((int)deciline == 3 && n % 3 == 0) {
                                
                                result = $"{d}{c}{b}{a}";
                                isBreak = true;
                                break;
                            }
                            if (isBreak) { break; }
                        }
                        if (isBreak) { break; }
                    }
                    if (isBreak) { break; }
                }
                if (isBreak) { break; }
            }

            if (result == String.Empty)
            {
                Console.WriteLine("Nothing found");
            }
            else {
                Console.WriteLine(result);
            }
        }
    }
}
