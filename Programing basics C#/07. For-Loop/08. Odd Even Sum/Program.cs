using System;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 1; i <= countNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else {
                    sumOdd += currentNum;
                }
            }            
            if (sumEven == sumOdd)
                Console.WriteLine($"Yes, sum = {sumEven}");
            else
                Console.WriteLine($"No, diff = {Math.Max(sumEven, sumOdd) - Math.Min(sumEven, sumOdd)}");
        }
    }
}