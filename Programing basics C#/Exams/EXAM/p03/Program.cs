using System;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string suvenirType = Console.ReadLine();
            int countSouvenirs = int.Parse(Console.ReadLine());


            bool invalidStock = false;
            bool invalidTeam = false;

            double neddedMoney = 0;
            if (team == "Argentina")
            {
                if (suvenirType == "flags") {
                    neddedMoney = 3.25;
                }
                else if (suvenirType == "caps")
                {
                    neddedMoney = 7.20;
                }
                else if (suvenirType == "posters")
                {
                    neddedMoney = 5.1;
                }
                else if (suvenirType == "stickers")
                {
                    neddedMoney = 1.25;
                }
                else
                {
                    invalidStock = true;
                }
            }
            else if (team == "Brazil") {
                if (suvenirType == "flags")
                {
                    neddedMoney = 4.2;
                }
                else if (suvenirType == "caps")
                {
                    neddedMoney = 8.5;
                }
                else if (suvenirType == "posters")
                {
                    neddedMoney = 5.35;
                }
                else if (suvenirType == "stickers")
                {
                    neddedMoney = 1.2;
                }
                else
                {
                    invalidStock = true;
                }
            }
            else if (team == "Croatia")
            {
                if (suvenirType == "flags")
                {
                    neddedMoney = 2.75;
                }
                else if (suvenirType == "caps")
                {
                    neddedMoney = 6.9;
                }
                else if (suvenirType == "posters")
                {
                    neddedMoney = 4.95;
                }
                else if (suvenirType == "stickers")
                {
                    neddedMoney = 1.1;
                }
                else
                {
                    invalidStock = true;
                }
            }
            else if (team == "Denmark")
            {
                if (suvenirType == "flags")
                {
                    neddedMoney = 3.1;
                }
                else if (suvenirType == "caps")
                {
                    neddedMoney = 6.5;
                }
                else if (suvenirType == "posters")
                {
                    neddedMoney = 4.8;
                }
                else if (suvenirType == "stickers")
                {
                    neddedMoney = 0.9;
                }
                else
                {
                    invalidStock = true;
                }
            }
            else
            {
                invalidTeam = true;
            }

            if (invalidTeam)
            {
                Console.WriteLine("Invalid country!");
            }
            else if (invalidStock)
            {
                Console.WriteLine("Invalid stock!");
            }
            else {
                Console.WriteLine($"Pepi bought {countSouvenirs} {suvenirType} of {team} for {(neddedMoney * countSouvenirs):F2} lv.");
            }
        }
    }
}
