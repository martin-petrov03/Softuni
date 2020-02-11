using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {            
            set
            {
                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException(nameof(value), "First name cannot contain fewer than 3 symbols!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {            
            set
            {
                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException(nameof(value), "Last name cannot contain fewer than 3 symbols!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(nameof(value), "Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        public decimal Salary
        {            
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException(nameof(value), "Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percent)
        {
            if (this.age < 30)
            {
                percent = percent / 2;
            }

            this.salary *= 1 + (percent / 100.0M);
        }
    }
}
