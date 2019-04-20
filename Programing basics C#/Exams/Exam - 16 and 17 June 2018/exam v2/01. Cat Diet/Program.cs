using System;

namespace _01._Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int prozentMaznini = int.Parse(Console.ReadLine());
            int prozentProteini = int.Parse(Console.ReadLine());
            int prozentVuglehidrati = int.Parse(Console.ReadLine());
            int totalCallories = int.Parse(Console.ReadLine());
            int prozentWater = int.Parse(Console.ReadLine());

            double totaGrammslMaznini = (prozentMaznini / 100.0 * totalCallories) / 9;
            double totalGrammsProteini = (prozentProteini / 100.0 * totalCallories) / 4;
            double totalGrammsBuglehidrati = (prozentVuglehidrati / 100.0 * totalCallories) / 4;

            double totalWight = totaGrammslMaznini + totalGrammsProteini + totalGrammsBuglehidrati;
            double calloriesForOneKgFood = totalCallories / totalWight;
            //calloriesForOneKgFood = (int)calloriesForOneKgFood;
            double calloriesForOneGrFood = calloriesForOneKgFood * (1 - prozentWater / 100.0);
            
            Console.WriteLine($"{(calloriesForOneGrFood):F4}");
        }
    }
}
