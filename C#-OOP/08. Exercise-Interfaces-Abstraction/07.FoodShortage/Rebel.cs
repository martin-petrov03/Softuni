namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Food = 0;
        }

        public string Name { get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
