using System;

namespace _03.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());

            string triangleType = string.Empty;
            if ((a < b + c) && (a > Math.Max(b, c) - Math.Min(b, c)))
            {            
                if (a == b && b == c)
                {
                    triangleType = "equilateral";
                }
                else if (a == b || a == c || b == c)
                {
                    triangleType = "isosceles";
                }
                else
                {
                    triangleType = "scalene";
                }
                Console.WriteLine($"Triangle with sides {a.ToString("0.#")}, {b.ToString("0.#")} and {c.ToString("0.#")} is {triangleType}.");
            }
            else {
                Console.WriteLine($"There is no triangle with sides {a.ToString("0.#")}, {b.ToString("0.#")} and {c.ToString("0.#")}.");
            }            
        }
    }
}