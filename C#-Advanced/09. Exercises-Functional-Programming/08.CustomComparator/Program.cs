using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArr = new List<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            List<int> evenNums = inputArr.Where(x => x % 2 == 0).ToList();
            List<int> oddNums = inputArr.Where(x => x % 2 != 0).ToList();

            evenNums.Sort();
            oddNums.Sort();

            Console.WriteLine($"{String.Join(" ", evenNums)} {String.Join(" ", oddNums)}");
        }
    }
}