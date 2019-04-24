using System;

namespace _06.Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
                      
            int firstNum = num % 10;
            num /= 10;
            int secondNum = num % 10;
            num /= 10;
            int thirdNum = num % 10;
            num /= 10;
            
            for (int i = 1; i <= firstNum; i++)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    for (int n = 1; n <= thirdNum; n++)
                    {
                        Console.WriteLine($"{i} * {j} * {n} = {i * j * n};");
                    }
                }
            }
        }
    }
}