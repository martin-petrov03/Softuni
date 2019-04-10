using System;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            int sum1 = 0;
            for (int i = 1; i <= countNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum1 += currentNum;
            }

            int sum2 = 0;
            for (int i = 1; i <= countNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum2 += currentNum;
            }

            if (sum1 == sum2)
                Console.WriteLine($"Yes, sum = {sum1}");
            else
                Console.WriteLine($"No, diff = {Math.Max(sum1, sum2) - Math.Min(sum1, sum2)}");
        }
    }
}