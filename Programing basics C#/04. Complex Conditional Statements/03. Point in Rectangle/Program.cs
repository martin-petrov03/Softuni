﻿using System;

namespace _03.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            string zPosition = "";
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2) { 
                zPosition = "Inside";                
            } else{
                zPosition = "Outside";
            }
            Console.WriteLine(zPosition);
        }
    }
}