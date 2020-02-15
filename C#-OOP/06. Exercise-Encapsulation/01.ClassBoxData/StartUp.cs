using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {            
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            if (length <= 0 || width <= 0 || height <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
                return;
            }

            Box box = new Box(length, width, height);
            box.printSurfaceArea();
            box.printLateralSurfaceArea();
            box.printVolume();
        }
    }
}
