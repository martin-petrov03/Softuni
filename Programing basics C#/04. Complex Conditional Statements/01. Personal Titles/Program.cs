using System;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());

            string salutation = "";

            if (sex == 'm')
            {
                if (age < 16)
                {
                    salutation = "Master";
                }
                else {
                    salutation = "Mr.";
                }
            }
            else if (sex == 'f')
            {
                if (age < 16)
                {
                    salutation = "Miss";
                }
                else
                {
                    salutation = "Ms.";
                }
            }
            else {
                Console.WriteLine("Death");
            }
            Console.WriteLine(salutation);
        }
    }
}