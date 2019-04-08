using System;

namespace _09.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Gcd(a, b));
        }
        static int Gcd(int a, int b) {
            int gcd = 0;
            while (a != b) {
                if (a > b) {
                    a -= b;
                }
                else {
                    b -= a;
                }
            }            
                gcd = a;
                return gcd;                    
        }
    }
}