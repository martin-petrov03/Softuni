using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Roof

            double height = (n + 1) / 2;
            int currentStars = 0;
            if (n % 2 == 1)
            {
                currentStars = 1;
            }
            else
            {
                currentStars = 2;
            }

            for (int row = 0; row < Math.Floor(height); row++)
            {
                int numOfDashes = (n - currentStars) / 2;
                Console.WriteLine(new string('-', numOfDashes) + new string('*', currentStars) + new string('-', numOfDashes));
                currentStars += 2;
            }            

            //The foundations of a house         
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("|" + new string('*', n - 2) + "|");
            }            
        }
    }
}