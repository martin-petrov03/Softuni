using System;

namespace _03.Ivanovi_s_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNights = int.Parse(Console.ReadLine());
            string currort = Console.ReadLine();
            string transport = Console.ReadLine();

            double prise = 0;           
            if (currort == "Miami")
            {
                if (countNights >= 1 && countNights <= 10) {                    
                    prise += (countNights * (2 * 24.99 + 3 * 14.99));
                }
                else if (countNights >= 11 && countNights <= 15)
                {
                    prise += (countNights * (2 * 22.99 + 3 * 11.99));
                }
                else if (countNights > 15)
                {
                    prise += (countNights * (2 * 20 + 3 * 10));
                }
            }
            else if (currort == "Canary Islands")
            {
                if (countNights >= 1 && countNights <= 10)
                {
                    prise += (countNights * (2 * 32.5 + 3 * 28.5));                
                }
                else if (countNights >= 11 && countNights <= 15)
                {
                    prise += (countNights * (2 * 30.5 + 3 * 25.6));
                }
                else if (countNights > 15)
                {
                    prise += (countNights * (2 * 28 + 3 * 22));                 ;
                }
            }
            else if (currort == "Philippines") {
                if (countNights >= 1 && countNights <= 10)
                {
                    prise += (countNights * (2 * 42.99 + 3 * 39.99));                    
                }
                else if (countNights >= 11 && countNights <= 15)
                {
                    prise += (countNights * (2 * 41 + 3 * 36));                   
                }
                else if (countNights > 15)
                {
                    prise += (countNights * (2 * 38.5 + 3 * 32.4));                    
                }
            }
            prise += prise * 25 / 100;

            if (transport == "train")
            {
                prise += 2 * 22.3 + 3 * 12.5;                
            }
            else if (transport == "bus")
            {
                prise += 2 * 45 + 3 * 37;
            }
            else if (transport == "airplane")
            {
                prise += 2 * 90 + 3 * 68.5;
            }                       
            Console.WriteLine($"{prise:F3}");
        }
    }
}