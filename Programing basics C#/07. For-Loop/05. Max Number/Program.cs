using System;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            for (int i = 1; i <= countNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if(currentNum > maxNum)
                    maxNum = currentNum;
            }
            Console.WriteLine(maxNum);
        }
    }
}