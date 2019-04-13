using System;

namespace _04.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double startSalary = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            string isSindical = Console.ReadLine();

            decimal totalSalary = (decimal)startSalary;      

            for (int i = 1; i <= int.MaxValue; i++)
            {
                totalSalary = totalSalary *(decimal) 1.06;//6 / 100m;
                int currentYear = i;

                if (currentYear % 5 == 0 || currentYear % 10 == 0)
                {
                    if (currentYear % 5 == 0)
                    {
                        totalSalary += 100;         
                    }
                    if (currentYear % 10 == 0)
                    {
                        totalSalary += 200;                        
                    }
                }
                else if (isSindical == "Yes")
                {
                   // totalSalary -= totalSalary * 1 / 100m;
                    totalSalary *= (decimal)0.99;
                }               
                if (i == years && totalSalary < 5000) {
                    Console.WriteLine($"Current salary: {totalSalary:F2}");
                    continue;
                }
                else if (totalSalary >= 5000 && i <= years)
                {
                    totalSalary = 5000;
                    Console.WriteLine($"Current salary: {totalSalary:F2}");
                    Console.WriteLine($"{0} more years to max salary.");                    
                    break;
                }
                if (totalSalary >= 5000) {
                    totalSalary = 5000;
                    Console.WriteLine($"{i - years} more years to max salary.");
                    break;
                }
            }            
        }
    }
}