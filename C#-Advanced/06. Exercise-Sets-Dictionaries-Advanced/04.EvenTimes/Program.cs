using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> repetCount = new Dictionary<int, int>();

            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (!repetCount.ContainsKey(currentNum))
                {
                    repetCount.Add(currentNum, 0);
                }               
                repetCount[currentNum]++;             
            }

            int evenTimesNum = repetCount                
                .SingleOrDefault(num => num.Value % 2 == 0)
                .Key;

            Console.WriteLine(evenTimesNum);
        }
    }
}
