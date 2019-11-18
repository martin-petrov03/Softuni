using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<Person> people = new List<Person>();
            
            while (line != "END")
            {
                string[] items = line.Split();

                string name = items[0];
                int age = int.Parse(items[1]);
                string town = items[2];

                Person currentPerson = new Person(name, age, town);
                people.Add(currentPerson);

                line = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine());
            
            if (index >= 0 && index < people.Count)
            {
                Person person = people[index];
                int countEquals = 1;

                foreach (Person currentPerson in people)
                {
                    if (currentPerson == person)
                    {
                        continue;
                    }

                    if (currentPerson.CompareTo(person) == 0)
                    {
                        countEquals++;
                    }
                }                

                if (countEquals == 1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine($"{countEquals} {people.Count - countEquals} {people.Count}");
                }
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}