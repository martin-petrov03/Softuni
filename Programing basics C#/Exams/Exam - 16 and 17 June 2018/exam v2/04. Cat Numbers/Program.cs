using System;

namespace _04._Cat_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= catsCount; i++)
            {
                string firstName = Console.ReadLine();
                string secondName = Console.ReadLine();               
                int lastNumsOfBirthYear = int.Parse(Console.ReadLine());

                string specialCode = $"{lastNumsOfBirthYear}{(int)firstName[0]}{(int)secondName[0]}{i}";
                Console.WriteLine(specialCode);
            }
        }
    }
}
