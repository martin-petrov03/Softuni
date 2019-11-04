using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int familyMembersCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < familyMembersCount; i++)
            {
                string[] line = Console.ReadLine()
                    .Split();
                string name = line[0];
                int age = int.Parse(line[1]);
                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }
            Person oldestFamilyMember = family.GetOldestMember();
            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }
}