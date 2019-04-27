using System;

namespace _4._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int countStops = int.Parse(Console.ReadLine());

            int totalPeople = countPeople;
            for (int i = 1; i <= countStops; i++)
            {
                int descending = int.Parse(Console.ReadLine());
                int rising = int.Parse(Console.ReadLine());

                totalPeople -= descending;
                totalPeople += rising;
                if(i % 2 == 0)
                {
                    totalPeople -= 2;
                }
                else
                {
                    totalPeople += 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {totalPeople}");
        }
    }
}
