namespace Restaurant
{
    public class Tea : HotBeverage
    {
        protected Tea(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {
        }
    }
}
