using System;
using System.Linq;

namespace _05._Credit_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int kursesCount = int.Parse(Console.ReadLine());

            double gradesSum = 0;
            double creditsSum = 0;
            for (int i = 1; i <= kursesCount; i++)
            {
                int creditsAndGrade = int.Parse(Console.ReadLine());

                string ex = creditsAndGrade.ToString();

                char c = ex.Last();
                double grade = double.Parse(c.ToString());
                
                gradesSum += grade;         
                double maxCredits = double.Parse(ex.TrimEnd(c));

                double currentCredits = 0;
                if (grade == 3) {
                    currentCredits = maxCredits / 2;
                }
                else if (grade == 4)
                {
                    currentCredits = maxCredits * 70 /100;
                }
                else if (grade == 5)
                {
                    currentCredits = maxCredits * 85 / 100;
                }
                else if (grade == 6)
                {
                    currentCredits = maxCredits;
                }
                creditsSum += currentCredits;
            }
            Console.WriteLine($"{creditsSum:F2}");
            Console.WriteLine($"{(gradesSum / kursesCount):F2}");
        }
    }
}
