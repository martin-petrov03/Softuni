namespace Composite
{
    public class GiftBase
    {
        private string name;
        private int price;

        protected GiftBase(string name, int price)
        {
            this.name = name;
            this.price = price;
        }        
    }
}
