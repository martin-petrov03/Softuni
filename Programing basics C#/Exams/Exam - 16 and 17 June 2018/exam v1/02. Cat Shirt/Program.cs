using System;

namespace _02._Cat_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sleeveLength = double.Parse(Console.ReadLine());
            double theFrontLength = double.Parse(Console.ReadLine());
            string fabricType = Console.ReadLine();
            string tie = Console.ReadLine();

            double size = theFrontLength * 2 + sleeveLength * 2;
            size += size * 0.1;

            double size1 = size / 100;
            
            double price = 0;
            if (fabricType == "Linen") {
                price = 15;
            }
            else if (fabricType == "Cotton")
            {
                price = 12;
            }
            else if (fabricType == "Denim")
            {
                price = 20;
            }
            else if (fabricType == "Twill")
            {
                price = 16;
            }
            else if (fabricType == "Flannel")
            {
                price = 11;
            }
            double totalPrice = price * size1 + 10;
            

            if (tie == "Yes") {
                totalPrice += totalPrice * 0.2;
            }
            
            Console.WriteLine($"The price of the shirt is: {totalPrice:F2}lv.");
        }
    }
}
