namespace CompositePattern
{
    using System;

    public class SingleGift : GiftBase
    {
        public SingleGift(string name, int price)
            : base(name, price)
        {

        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{name} with price {price}");
            return this.price;
        }
    }
}
