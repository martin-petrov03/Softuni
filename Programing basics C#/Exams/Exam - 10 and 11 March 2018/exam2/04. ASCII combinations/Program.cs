using System;

namespace _4_CharsSum
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int maxSum = 0;

            int sumDigits = 0;
            int sumCapsLetters = 0;
            int sumSmallLetters = 0;
            int sumOthers = 0;

            string digits = "";
            string capsLetters = "";
            string smallLetters = "";
            string others = "";


            for (int i = 0; i < num; i++)
            {
                char currSymbol = char.Parse(Console.ReadLine());

                int currNum = (int)currSymbol;

                if (currSymbol >= '0' && currSymbol <= '9')
                {
                    digits += currSymbol;
                    sumDigits += currNum;

                    if (sumDigits > maxSum)
                    {
                        maxSum = sumDigits;
                    }

                }
                else if (currSymbol >= 'A' && currSymbol <= 'Z')
                {
                    capsLetters += currSymbol;
                    sumCapsLetters += currNum;

                    if (sumCapsLetters > maxSum)
                    {
                        maxSum = sumCapsLetters;
                    }
                }
                else if (currSymbol >= 'a' && currSymbol <= 'z')
                {
                    smallLetters += currSymbol;
                    sumSmallLetters += currNum;

                    if (sumSmallLetters > maxSum)
                    {
                        maxSum = sumSmallLetters;
                    }
                }
                else
                {
                    others += currSymbol;
                    sumOthers += currNum;

                    if (sumOthers > maxSum)
                    {
                        maxSum = sumOthers;
                    }
                }
            }

            Console.WriteLine($"Biggest ASCII sum is:{maxSum}");

            if (sumDigits == maxSum)
            {
                Console.WriteLine($"Combination of characters is:{digits}");
            }
            else if (sumCapsLetters == maxSum)
            {
                Console.WriteLine($"Combination of characters is:{capsLetters}");
            }
            else if (sumSmallLetters == maxSum)
            {
                Console.WriteLine($"Combination of characters is:{smallLetters}");
            }
            else
            {
                Console.WriteLine($"Combination of characters is:{others}");
            }
        }
    }
}