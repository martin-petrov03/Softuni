using System;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());            

            double prise = 0;
            if (town == "Sofia")
            {
                if (drink == "coffee") {
                    prise = 0.5;
                }
                else if (drink == "water")
                {
                    prise = 0.8;
                }
                else if (drink == "beer")
                {
                    prise = 1.2;
                }
                else if (drink == "sweets")
                {
                    prise = 1.45;
                }
                else if (drink == "peanuts")
                {
                    prise = 1.6;
                }
            }
            else if (town == "Plovdiv")
            {
                if (drink == "coffee")
                {
                    prise = 0.4;
                }
                else if (drink == "water")
                {
                    prise = 0.7;
                }
                else if (drink == "beer")
                {
                    prise = 1.15;
                }
                else if (drink == "sweets")
                {
                    prise += 1.30;
                }
                else if (drink == "peanuts")
                {
                    prise = 1.5;
                }
            }
            else if (town == "Varna")
            {
                if (drink == "coffee")
                {
                    prise = 0.45;
                }
                else if (drink == "water")
                {
                    prise = 0.7;
                }
                else if (drink == "beer")
                {
                    prise = 1.1;
                }
                else if (drink == "sweets")
                {
                    prise = 1.35;
                }
                else if (drink == "peanuts")
                {
                    prise = 1.55;
                }
            }
            else {
                Console.WriteLine("Error");
            }
            double totalPrise = count * prise;
            Console.WriteLine(totalPrise);
        }
    }
}