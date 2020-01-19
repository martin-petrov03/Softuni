using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    class Rectangle
    {
        public Rectangle(int top, int left, int bottom, int right)
        {
            this.TopLeftCoordinates = new Point(top, left);
            this.BottomRightCoordinates = new Point(bottom, right);
        }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeftCoordinates = topLeft;
            this.BottomRightCoordinates = bottomRight;
        }

        public Point TopLeftCoordinates { get; private set; }

        public Point BottomRightCoordinates { get; private set; }

        public bool Contains(Point point)
        {
            bool isInX = point.X >= TopLeftCoordinates.X && 
                point.X <= BottomRightCoordinates.X;

            bool isInY = point.Y >= TopLeftCoordinates.Y && 
                point.Y <= BottomRightCoordinates.Y;

            return isInX && isInY;
        }
    }
}