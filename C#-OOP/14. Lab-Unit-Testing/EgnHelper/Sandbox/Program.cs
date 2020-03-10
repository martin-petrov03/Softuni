using EgnHelper;
using System;

namespace Sandbox
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValidateFromUser(new EgnValidator());
        }

        public static void ValidateFromUser(IEgnValidator validator)
        {
            string egn = Console.ReadLine();            
            Console.WriteLine("Valid: " + validator.IsValid(egn));
        }
    }
}
