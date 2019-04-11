using System;

namespace _07._Graduation_pt._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int failsCount = 0;
            double gradesSum = 0;
            while (name != "END")
            {
                for (int i = 1; i <= 12; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    if (grade <= 3)
                        failsCount++;
                    if (failsCount == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        gradesSum = 0;
                        break;
                    }
                    gradesSum += grade;
                    if (i == 12)
                    {
                        Console.WriteLine($"{name} graduated. Average grade: {(gradesSum / 12):F2}");
                        gradesSum = 0;
                    }
                }
                name = Console.ReadLine();
            }
        }
    }
}
