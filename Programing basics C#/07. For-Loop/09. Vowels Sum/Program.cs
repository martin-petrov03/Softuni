using System;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int sumOfPositions = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'a' || inputString[i] == 'A')
                {
                    sumOfPositions += 1;
                }
                else if (inputString[i] == 'e' || inputString[i] == 'E')
                {
                    sumOfPositions += 2;
                }
                else if (inputString[i] == 'i' || inputString[i] == 'I')
                {
                    sumOfPositions += 3;
                }
                else if (inputString[i] == 'o' || inputString[i] == 'O')
                {
                    sumOfPositions += 4;
                }
                else if (inputString[i] == 'u' || inputString[i] == 'U') {
                    sumOfPositions += 5;
                }
            }
            Console.WriteLine(sumOfPositions);
        }
    }
}
//A/a Ee Ii Oo Uu
