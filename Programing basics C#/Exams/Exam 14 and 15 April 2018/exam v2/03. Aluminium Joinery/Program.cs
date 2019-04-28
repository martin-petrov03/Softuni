using System;

namespace _3._Aluminium_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemsCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string shipMethod = Console.ReadLine();

            double prise = 0;
            int discount = 0;

            if (type == "90X130") {
                prise = 110;

                if (itemsCount > 30 && itemsCount <= 60) {
                    discount = 5;
                }
                else if(itemsCount > 60) {
                    discount = 8;
                }
            }
            else if (type == "100X150")
            {
                prise = 140;

                if (itemsCount > 40 && itemsCount <= 80)
                {
                    discount = 6;
                }
                else if (itemsCount > 80)
                {
                    discount = 10;
                }
            }
            else if (type == "130X180")
            {
                prise = 190;

                if (itemsCount > 20 && itemsCount <= 50)
                {
                    discount = 7;
                }
                else if (itemsCount > 50)
                {
                    discount = 12;
                }
            }
            else if (type == "200X300")
            {
                prise = 250;

                if (itemsCount > 25 && itemsCount <= 50)
                {
                    discount = 9;
                }
                else if (itemsCount > 50)
                {
                    discount = 14;
                }
            }

            
            double totalPrise = prise * itemsCount;
            totalPrise -= totalPrise * discount / 100;

            if (shipMethod == "With delivery")
            {
                totalPrise += 60;
            }

            if (itemsCount >= 100)
            {
                totalPrise -= totalPrise * 4 / 100;
            }

            if (itemsCount < 10)
            {
                Console.WriteLine($"Invalid order");
            }
            else
            {
                Console.WriteLine($"{totalPrise:F2} BGN");
            }
        }
    }
}
