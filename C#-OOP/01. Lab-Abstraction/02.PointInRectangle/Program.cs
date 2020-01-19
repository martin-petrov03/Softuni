﻿using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangleCoordinates = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            Point topLeftPoint = new Point(rectangleCoordinates[0], rectangleCoordinates[1]);
            Point bottomRightPoint = new Point(rectangleCoordinates[2], rectangleCoordinates[3]);

            Rectangle rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            int pointsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointsCount; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Point currentPoint = new Point(pointCoordinates[0], pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }
}