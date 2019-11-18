using System.Collections;

namespace ComparingObjects
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person otherPerson)
        {
            if (this.Name.CompareTo(otherPerson.Name) != 0)
            {
                return this.Name.CompareTo(otherPerson.Name);
            }

            if (this.Age.CompareTo(otherPerson.Age) != 0)
            {
                return this.Age.CompareTo(otherPerson.Age);
            }

            if (this.Town.CompareTo(otherPerson.Town) != 0)
            {
                return this.Town.CompareTo(otherPerson.Town);
            }

            return 0;            
        }
    }
}