using System;

namespace _09.Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string bestName = string.Empty;
            int bestScope = int.MinValue;
            while (input != "STOP")
            {                
                int currentScope = 0;
                string currentName = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    currentScope += (int)input[i];
                    currentName += input[i];
                }
                if (currentScope > bestScope)
                {
                    bestScope = currentScope;
                    bestName = currentName;
                }
                input = Console.ReadLine();
            }
                Console.WriteLine($"Winner is {bestName} - {bestScope}! ");
        }
    }
}