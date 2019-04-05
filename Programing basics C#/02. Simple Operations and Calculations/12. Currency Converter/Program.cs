using System;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double currency = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double money=0;
            var type="";

            if (inputCurrency == "BGN") {                
                if (outputCurrency == "USD")
                {
                    double usd = currency / 1.79549;
                    money = usd;
                    type = "USD";
                } else if (outputCurrency == "EUR") {
                    double eur = currency / 1.95583;
                    money = eur;
                    type = "EUR";
                }
                else if (outputCurrency == "GBP") {
                    double gbp = currency / 2.53405;
                    money = gbp;
                    type = "GBP";
                }
            } else if (inputCurrency == "USD") {
                double bgn = 1.79549 * currency;
                if (outputCurrency == "BGN")
                {
                    money = bgn;
                    type = "BGN";
                }
                else if (outputCurrency == "EUR")
                {
                    double eur = bgn / 1.95583;
                    money = eur;
                    type = "EUR";
                }
                else if (outputCurrency == "GBP")
                {
                    double gbp = bgn / 2.53405;
                    money = gbp;
                    type = "GBP";
                }
            } else if (inputCurrency == "EUR") {
                double bgn = 1.95583 * currency;
                if (outputCurrency == "BGN")
                {
                    money = bgn;
                    type = "BGN";
                }
                else if (outputCurrency == "USD")
                {
                    double usd = bgn / 1.79549;
                    money = usd;
                    type = "USD";
                }
                else if (outputCurrency == "GBP")
                {
                    double gbp = bgn / 2.53405;
                    money = gbp;
                    type = "GBP";
                }
            } else if (inputCurrency == "GBP") {
                double bgn = 2.53405 * currency;
                if (outputCurrency == "BGN")
                {
                    money = bgn;
                    type = "BGN";
                }
                else if (outputCurrency == "USD")
                {
                    double usd = bgn / 1.79549;
                    money = usd;
                    type = "USD";
                }
                else if (outputCurrency == "EUR")
                {
                    double eur = bgn / 1.95583;
                    money = eur;
                    type = "EUR";
                }
            }
            Console.WriteLine($"{money:F2} {type}");
        }
    }
}