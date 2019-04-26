using System;

namespace _02._Annual_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsExperience = int.Parse(Console.ReadLine());
            string developerType = Console.ReadLine();

            double salary = 0;
            if (developerType == "C# Developer")
            {
                salary = 5400;
            }
            else if (developerType == "Java Developer")
            {
                salary = 5700;
            }
            else if (developerType == "Front-End Web Developer")
            {
                salary = 4100;
            }
            else if (developerType == "UX / UI Designer")
            {
                salary = 3100;
            }
            else if (developerType == "Game Designer")
            {
                salary = 3600;
            }

            if (yearsExperience <= 5) {
                salary = salary - salary * 65.8 / 100;
            }
            double yearSalary = salary * 12;
            Console.WriteLine($"Total earned money: {yearSalary:F2} BGN");
        }
    }
}
