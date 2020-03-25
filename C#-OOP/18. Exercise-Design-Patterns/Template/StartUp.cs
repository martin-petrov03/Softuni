using System;

namespace Template
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Product productInBulgaria = new Product(30, new EnglandVATStrategy());

            Console.WriteLine(productInBulgaria.TotalPrice);
        }
    }
}
