using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < countLines; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (students.ContainsKey(line[0]))
                {
                    students[line[0]].Add(double.Parse(line[1]));
                }
                else
                {
                    students[line[0]] = new List<double>();
                    students[line[0]].Add(double.Parse(line[1]));
                   
                }
            }

            foreach (var student in students)
            {
                string name = student.Key;
                var grades = student.Value;
                double average = grades.Average();

                Console.Write($"{name} -> ");
                foreach (double grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.Write($"(avg: {average:f2})");
                Console.WriteLine();
            }
        }
    }
}
