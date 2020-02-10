namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public override string ToString()
        {
            var yearsString = "years";
            if (this.Age == 1)
            {
                yearsString = "year";
            }
            return $"{this.FirstName} {this.LastName} is {this.Age} {yearsString} old.";
        }
    }
}
