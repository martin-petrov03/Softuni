namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class CompositeGift : Gift, IGiftOperation
    {
        private List<Gift> gifts;

        public CompositeGift(string name, int price)
            :base(name, price)
        {
            this.gifts = new List<Gift>();
        }

        public override int CalculateTotalPrice()
        {
            int totalPrice = (int)(base.price * 1.2);

            Console.WriteLine($"{base.name} contains the following prices:");

            foreach (Gift gift in this.gifts)
            {
                totalPrice += gift.CalculateTotalPrice();
            }

            Console.WriteLine($"Total price: {totalPrice}");
            return totalPrice;
        }

        public override void Add(Gift gift)
        {
            this.gifts.Add(gift);
        }

        public override void Remove(Gift gift)
        {
            this.gifts.Remove(gift);
        }

        public void Update(Gift gift)
        {
            throw new NotImplementedException();
        }
    }
}
