namespace AbstractClass
{
    using System.Collections.Generic;

    public class SandwichMenu
    {
        private Dictionary<string, Sandwich> sandwichMenuByNames;

        public SandwichMenu()
        {
            this.sandwichMenuByNames = new Dictionary<string, Sandwich>();
        }

        public Sandwich this[string name]
        {
            get => this.sandwichMenuByNames[name];
            set => this.sandwichMenuByNames[name] = value;
        }
    }
}
