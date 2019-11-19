using System;

namespace LaptopShop
{
    public class Program
    {
        static void Main(string[] args)
        {            
            string laptopMake = "Acer";
            string laptopModel = "Aspire 5";
            double laptopDisplaySize = 15.6;
            decimal laptopPrice = 1500;
            int laptopRam = 8;
            int laptopSsd = 480;

            Laptop laptop = new Laptop(laptopMake, laptopModel, laptopDisplaySize, laptopPrice, laptopRam, laptopSsd);
            Laptop laptop1 = new Laptop("Lenovo", "V130-15IKB", laptopDisplaySize, 2000, 16, 512);
            LaptopShop shop = new LaptopShop();

            shop.AddLaptop(laptop);
            shop.AddLaptop(laptop1);
            shop.printAllLaptops(x => Console.WriteLine(x.FullInfo()));
        }
    }
}