using System;

namespace _11.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;
            for (int i = 1; i <= countNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNum) {
                    maxNum = currentNum;
                }
                sum += currentNum;
            }
            sum -= maxNum;
            if (maxNum == sum)
            {                                   
                    Console.WriteLine($"Yes");
                    Console.WriteLine($"sum = {sum}");                
            }
            else {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}