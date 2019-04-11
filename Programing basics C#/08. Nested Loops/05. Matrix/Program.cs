using System;

namespace _05.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            for (int first = num1; first <= num2; first++)
            {
                for (int second = num1; second <= num2; second++)
                {
                    for (int third = num3; third <= num4; third++)
                    {
                        for (int fourth = num3; fourth <= num4; fourth++)
                        {
                            if (first != second && third != fourth)
                            {
                                if (first + fourth == third + second) {
                                    Console.WriteLine($"{first}{second}");
                                    Console.WriteLine($"{third}{fourth}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }                                  
                    
            }            
        }
    }
}