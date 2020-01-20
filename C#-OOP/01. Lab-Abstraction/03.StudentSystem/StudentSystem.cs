using System;
using System.Collections.Generic;
using System.Text;

namespace _03.StudentSystem
{
    public class StudentSystem
    {
        private StudentsDatabase students;

        public StudentSystem()
        {
            this.students = new StudentsDatabase();
        }

        public void ParseCommands()
        {
            while (true)
            {
                string[] args = Console.ReadLine().Split();
                string commandName = args[0];

                if (commandName == "Create")
                {
                    this.Create(args);
                }
                else if (commandName == "Show")
                {
                    this.Show(args);
                }
                else if (commandName == "Exit")
                {
                    return;
                }
            }
        }

        private void Show(string[] args)
        {
            string name = args[1];
            Student student = this.students.Find(name);
            if (student != null)
            {
                Console.WriteLine(student);
            }
        }

        private void Create(string[] args)
        {
            string name = args[1];
            int age = int.Parse(args[2]);
            double grade = double.Parse(args[3]);
            this.students.Add(name, age, grade);
        }
    }
}