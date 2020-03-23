namespace Composite
{
    using System;
    
    public class SingleGift : Gift
    {
        public SingleGift() 
            : base("Single Gift", 10)
        {
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
