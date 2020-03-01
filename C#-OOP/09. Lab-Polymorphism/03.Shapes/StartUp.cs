using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(12);
            Shape rectangle = new Rectangle(12, 12);

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.Draw());            
        }
    }
}
