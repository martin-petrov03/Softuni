using System;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialNum = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isLarger = (name, num)
                => name.Sum(x => x) >= num;
            Func<string[], Func<string, int, bool>, string> nameFilter = (inputName, isLargerFilter)
                => inputName.FirstOrDefault(x => isLargerFilter(x, specialNum));

            string resultName = nameFilter(input, isLarger);
            Console.WriteLine(resultName);
        }
    }
}