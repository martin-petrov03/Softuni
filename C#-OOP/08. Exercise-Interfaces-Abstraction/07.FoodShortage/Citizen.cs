namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, int age, string id, string birthdayDate)
        {
            this.Name = name;
            this.Food = 0;
        }

        public string Name { get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
