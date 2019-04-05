using System;
using System.Globalization;

namespace _13.Lawful_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);            
            date = date.AddDays(999);
            Console.WriteLine(date.ToString(format));
        }
    }
}