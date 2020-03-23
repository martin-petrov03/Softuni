namespace Composite
{
    using System;

    public abstract class Gift
    {
        protected string name;
        protected int price;

        protected Gift(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual int CalculateTotalPrice()
        {
            int totalPrice = (int)(this.price * 1.2);

            Console.WriteLine($"{this.name} with the price {totalPrice}");

            return totalPrice;
        }

        public abstract void Add(Gift gift);

        public abstract void Remove(Gift gift);
    }
}
