using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < countPeople; i++)
            {
                string[] line = Console.ReadLine()
                    .Split();
                string name = line[0];
                int age = int.Parse(line[1]);
                if (age > 30)
                {
                    Person currentPerson = new Person(name, age);
                    family.AddMember(currentPerson);
                }
            }
            List<Person> sortedFamily = family.sortPeople();
            foreach (Person currentPerson in sortedFamily)
            {
                Console.WriteLine($"{currentPerson.Name} - {currentPerson.Age}");
            }
        }
    }
}