namespace Composite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CompositeGift compositeGift = new CompositeGift("Composite gift", 50);
            CompositeGift anotherCompositeGift = new CompositeGift("Composite gift", 40);

            SingleGift singleGift = new SingleGift();
            DoubleGift doubleGift = new DoubleGift();

            compositeGift.Add(anotherCompositeGift);
            compositeGift.Add(singleGift);
            compositeGift.Add(doubleGift);

            compositeGift.CalculateTotalPrice();
        }
    }
}
