namespace AbstractClass
{
    public class Sandwich : SandwichPrototype
    {
        public Sandwich(string meat, string cheese, string bread, string veggies)
        {
            this.Meat = meat;
            this.Cheese = cheese;
            this.Bread = bread;
            this.Veggies = veggies;
        }

        public string Meat { get; set; }

        public string Cheese { get; set; }

        public string Bread { get; set; }

        public string Veggies { get; set; }
        
        public override Sandwich Clone()
        {
            return this.MemberwiseClone() as Sandwich;
        }
    }
}
