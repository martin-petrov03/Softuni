using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretPass = "s3cr3t!P@ssw0rd";
            string inputPass = Console.ReadLine();
            if (inputPass == secretPass)
            {
                Console.WriteLine("Welcome");
            }
            else {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}