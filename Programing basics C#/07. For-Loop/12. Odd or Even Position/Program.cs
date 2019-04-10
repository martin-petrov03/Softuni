using System;
using System.Linq;
using System.Collections.Generic;

namespace _12.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());
            List<double> evenNums = new List<double>{ };
            List<double> oddNums = new List<double> { };           

            for (int i = 1; i <= numsCount; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
               
                if (i % 2 == 0) {
                    evenNums.Add(currentNum);
                }
                else {
                    oddNums.Add(currentNum);
                }
            }

            if (oddNums.Count() == 0)
            {
                Console.WriteLine("OddSum = 0");
                Console.WriteLine("OddMin = No");
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine($"OddSum = {oddNums.Sum()}");
                Console.WriteLine($"OddMin = {oddNums.Min()}");
                Console.WriteLine($"OddMax = {oddNums.Max()}");
            }


            if (evenNums.Count() == 0)
            {
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine($"EvenSum = {evenNums.Sum()}");
                Console.WriteLine($"EvenMin = {evenNums.Min()}");
                Console.WriteLine($"EvenMax = {evenNums.Max()}");
            }
        }
    }
}