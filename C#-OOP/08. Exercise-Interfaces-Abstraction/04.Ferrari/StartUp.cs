using System;

namespace Ferrari
{
    public class StartUp
    {
        private const string Model = "488-Spider";

        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            Ferrari car = new Ferrari(Model, driver);

            Console.WriteLine(car);
        }
    }
}
