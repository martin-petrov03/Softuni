using System;

namespace _3._Cellphones
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int gsmCount = int.Parse(Console.ReadLine());
            string gsmMark = Console.ReadLine();

            int discount = 0;
            double prise = 0;
            if (gsmMark == "Gsm4e")
            {
                prise = 20.50;
                discount += 1;                
            }
            else if (gsmMark == "Mobifon4e") {
                prise = 50.75;
                discount += 2;
            }
            else if (gsmMark == "Telefon4e")
            {
                prise = 115;
                discount += 3;
            }

            if (gsmCount > 10 && gsmCount <= 20)
            {
                discount += 2;
            }
            else if (gsmCount >= 20 && gsmCount <= 50)
            {
                discount += 5;
            }
            else if (gsmCount > 50)
            {
                discount += 7;
            }
            prise *= gsmCount;
            double totalSum = prise - prise * discount / 100;

            if (totalSum <= budget) {
                Console.WriteLine($"The company bought all mobile phones. {(budget - totalSum):F2} leva left.");
            }
            else{
                Console.WriteLine($"Not enough money for all mobiles. Company needs {(totalSum - budget):F2} more leva.");
            }
        }
    }
}
