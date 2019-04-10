using System;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;
            for (int i = 1; i <= countNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < minNum)
                    minNum = currentNum;
            }
            Console.WriteLine(minNum);
        }
    }
}