using System;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string inputType = Console.ReadLine();
            string outputType = Console.ReadLine();
            if (inputType == outputType)
            {
                Console.WriteLine(Math.Round(num, 8));
            }
            else
            {
                if (inputType == "m")
                {
                    if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(num * 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(num * 100, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(num * 0.000621371192, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(num * 39.3700787, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(num * 0.001, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(num * 3.2808399, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(num * 1.0936133, 8));
                    }
                }
                else if (inputType == "mm")
                {
                    double meter = num / 1000;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(num / 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(meter * 100, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(meter * 0.000621371192, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(meter * 39.3700787, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(meter * 0.001, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(meter * 3.2808399, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(meter * 1.0936133, 8));
                    }
                }
                else if (inputType == "cm")
                {
                    double meter = num / 100;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(num/100, 8));
                    }
                    else if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(num * 10, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(meter * 0.000621371192, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(meter * 39.3700787, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(meter * 0.001, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(meter * 3.2808399, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(meter * 1.0936133, 8));
                    }
                }
                else if (inputType == "mi")
                {
                    double meter = num / 0.000621371192;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(meter, 8));
                    }
                    else if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(meter * 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(meter * 100, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(meter * 39.3700787, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(meter * 0.001, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(meter * 3.2808399, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(meter * 1.0936133, 8));
                    }
                }
                else if (inputType == "in")
                {
                    double meter = num / 39.3700787;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(meter, 8));
                    }
                    else if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(meter * 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(meter * 100, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(meter * 0.000621371192, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(meter * 0.001, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(meter * 3.2808399, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(meter * 1.0936133, 8));
                    }
                }
                else if (inputType == "km")
                {
                    double meter = num / 0.001;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(num * 1000, 8));
                    }
                    else if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(meter * 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(meter * 100, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(meter * 0.000621371192, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(meter * 39.3700787, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(meter * 3.2808399, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(meter * 1.0936133, 8));
                    }
                }
                else if (inputType == "ft")
                {
                    double meter = num / 3.2808399;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(meter, 8));
                    }
                    else if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(meter * 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(meter * 100, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(meter * 0.000621371192, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(meter * 39.3700787, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(meter * 0.001, 8));
                    }
                    else if (outputType == "yd")
                    {
                        Console.WriteLine(Math.Round(meter * 1.0936133, 8));
                    }
                }
                else if (inputType == "yd")
                {
                    double meter = num / 1.0936133;
                    if (outputType == "m")
                    {
                        Console.WriteLine(Math.Round(meter, 8));
                    }
                    else if (outputType == "mm")
                    {
                        Console.WriteLine(Math.Round(meter * 1000, 8));
                    }
                    else if (outputType == "cm")
                    {
                        Console.WriteLine(Math.Round(meter * 100, 8));
                    }
                    else if (outputType == "mi")
                    {
                        Console.WriteLine(Math.Round(meter * 0.000621371192, 8));
                    }
                    else if (outputType == "in")
                    {
                        Console.WriteLine(Math.Round(meter * 39.3700787, 8));
                    }
                    else if (outputType == "km")
                    {
                        Console.WriteLine(Math.Round(meter * 0.001, 8));
                    }
                    else if (outputType == "ft")
                    {
                        Console.WriteLine(Math.Round(meter * 3.2808399, 8));
                    }
                }
            }
        }
    }
}