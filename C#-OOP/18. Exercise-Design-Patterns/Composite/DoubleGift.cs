namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class DoubleGift : Gift
    {
        private List<Gift> gifts;

        public DoubleGift()
            :base("Double Gift", 25)
        {
            gifts = new List<Gift>();
        }

        public override void Add(Gift gift)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Gift gift)
        {
            throw new NotImplementedException();
        }
    }
}
