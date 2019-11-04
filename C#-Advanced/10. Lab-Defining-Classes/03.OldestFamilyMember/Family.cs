namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }

        public void AddMember(Person memeber)
        {
            familyMembers.Add(memeber);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = familyMembers.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldestPerson;
        }
    }
}