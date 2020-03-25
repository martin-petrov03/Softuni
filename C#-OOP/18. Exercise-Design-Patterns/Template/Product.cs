namespace Template
{
    public class Product
    {
        private VATStrategy vatStrategy;

        public Product(double basePrice, VATStrategy vatStrategy)
        {
            this.BasePrice = basePrice;
            this.vatStrategy = vatStrategy;
        }        

        public double BasePrice { get; set; }

        public double TotalPrice => this.BasePrice + (this.BasePrice * this.vatStrategy.GetVAT() / 100);
    }
}
