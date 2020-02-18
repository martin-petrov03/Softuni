using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                this.radius = value;
            }
        }        

        public void Draw()
        {            
            for (int row = 0; row < this.Radius * 2; row++)
            {
                for (int col = 0; col < this.Radius * 2; col++)
                {
                    double distance = Math.Ceiling(Math.Sqrt((row - this.Radius) * (row - this.Radius) + (col - this.Radius) * (col - this.Radius)));
               
                    if (distance == this.Radius)
                    {
                        Console.Write("**");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }            
        }
    }
}
