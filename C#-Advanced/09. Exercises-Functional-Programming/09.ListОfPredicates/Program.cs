using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.List
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<int> nums = Enumerable.Range(1, num).ToList();
            int[] deviders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (int currentNumber in deviders)
            {
                predicates.Add(x => x % currentNumber == 0);
            }
            for (int i = 0; i < nums.Count; i++)
            {                
                foreach (var predicate in predicates)
                {
                    if (!predicate(nums[i]))
                    {
                        nums.Remove(nums[i]);
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}