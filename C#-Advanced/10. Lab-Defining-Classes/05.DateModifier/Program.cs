using System;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] frirstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            DateTime firstDate = new DateTime(frirstInput[0], frirstInput[1], frirstInput[2]);
            DateTime secondDate = new DateTime(secondInput[0], secondInput[1], secondInput[2]);

            DateModifier differenceBetweenTwoDates = new DateModifier();
            differenceBetweenTwoDates.FirstDate = firstDate;
            differenceBetweenTwoDates.SecondDate = secondDate;

            Console.WriteLine(differenceBetweenTwoDates.Dates());
        }
    }
}